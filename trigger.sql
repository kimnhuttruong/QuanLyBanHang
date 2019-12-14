alter trigger CapNhatSoLuong
on STOCK_INWARD_DETAIL
for insert,update
as
begin
	
	declare @soluong int
	set @soluong=0
	declare @mahang nvarchar(30)
	declare @makho nvarchar(30)
	select @mahang=s.Product_ID,@soluong=SUM(CAST(s.Quantity AS int)) ,@makho=s.Stock_ID
	from STOCK_INWARD_DETAIL s,inserted i
	where s.Product_ID=i.Product_ID and s.Stock_ID=i.Stock_ID
	group by s.Product_ID,s.Stock_ID

	declare @soluongban int
	set @soluongban=0
	select @soluongban=SUM(CAST(s.Quantity AS int))
	from STOCK_OutWARD_DETAIL s
	where  s.Stock_ID=@makho and s.Product_ID=@mahang
	group by s.Product_ID,s.Stock_ID

	update INVENTORY_DETAIL set Quantity= @soluong-@soluongban where Product_ID=@mahang and Stock_ID=@makho

end
go
create trigger CapNhatSoLuong_nhap_delete
on STOCK_INWARD_DETAIL
for delete,update
as
begin
	
	declare @soluong int
	set @soluong=0
	declare @mahang nvarchar(30)
	declare @makho nvarchar(30)
	select @mahang=s.Product_ID,@soluong=SUM(CAST(s.Quantity AS int)) ,@makho=s.Stock_ID
	from STOCK_INWARD_DETAIL s,deleted i
	where s.Product_ID=i.Product_ID and s.Stock_ID=i.Stock_ID
	group by s.Product_ID,s.Stock_ID

	declare @soluongban int
	set @soluongban=0
	select @soluongban=SUM(CAST(s.Quantity AS int))
	from STOCK_OutWARD_DETAIL s
	where  s.Stock_ID=@makho and s.Product_ID=@mahang
	group by s.Product_ID,s.Stock_ID

	update INVENTORY_DETAIL set Quantity= @soluong-@soluongban where Product_ID=@mahang and Stock_ID=@makho

end
go
alter trigger CapNhatSoLuongXuat
on STOCK_OUTWARD_DETAIL
for insert,update
as
begin
	
	declare @soluong int
	set @soluong=0
	declare @mahang nvarchar(30)
	declare @makho nvarchar(30)
	select @mahang=s.Product_ID,@soluong=SUM(CAST(s.Quantity AS int)) ,@makho=s.Stock_ID
	from STOCK_INWARD_DETAIL s,inserted i
	where s.Product_ID=i.Product_ID and s.Stock_ID=i.Stock_ID
	group by s.Product_ID,s.Stock_ID

	declare @soluongban int
	set @soluongban=0
	select @soluongban=SUM(CAST(s.Quantity AS int))
	from STOCK_OutWARD_DETAIL s
	where s.Stock_ID=@makho and s.Product_ID=@mahang
	group by s.Product_ID,s.Stock_ID

	update INVENTORY_DETAIL set Quantity= @soluong-@soluongban where Product_ID=@mahang and Stock_ID=@makho

end
go
create trigger CapNhatSoLuongXuat_delete
on STOCK_OUTWARD_DETAIL
for delete,update
as
begin
	
	declare @soluong int
	set @soluong=0
	declare @mahang nvarchar(30)
	declare @makho nvarchar(30)
	select @mahang=s.Product_ID,@soluong=SUM(CAST(s.Quantity AS int)) ,@makho=s.Stock_ID
	from STOCK_INWARD_DETAIL s,deleted i
	where s.Product_ID=i.Product_ID and s.Stock_ID=i.Stock_ID
	group by s.Product_ID,s.Stock_ID

	declare @soluongban int
	set @soluongban=0
	select @soluongban=SUM(CAST(s.Quantity AS int))
	from STOCK_OutWARD_DETAIL s
	where s.Stock_ID=@makho and s.Product_ID=@mahang
	group by s.Product_ID,s.Stock_ID

	update INVENTORY_DETAIL set Quantity= @soluong-@soluongban where Product_ID=@mahang and Stock_ID=@makho

end
go
alter trigger CapNhatSoLuong_INVENTORY_DETAIL_them
on INVENTORY_DETAIL
for insert
as
begin
	declare @soluong int
	declare @ma nvarchar(30)
	declare @makho nvarchar(30)
	select @ma=i.Product_ID,@makho=i.Stock_ID,@soluong=i.Quantity
	from inserted i

	if(@ma in (select Product_ID from INVENTORY_DETAIL))
	if(@makho in (select Stock_ID from INVENTORY_DETAIL))
		begin
		update INVENTORY_DETAIL set Quantity= Quantity+ @soluong where Product_ID=@ma and Stock_ID=@makho
		
		end
end
go
create trigger CapNhatSoLuong_STOCK_TRANSFER_DETAIL_them
on STOCK_TRANSFER_DETAIL
for insert,update
as
begin
	declare @soluong int
	declare @ma nvarchar(30)
	declare @makhoxuat nvarchar(30)
	declare @makhonhan nvarchar(30)
	select @ma=i.Product_ID,@makhoxuat=i.OutStock,@makhonhan=i.InStock,@soluong=i.Quantity
	from inserted i
	update INVENTORY_DETAIL set Quantity= Quantity+ @soluong where Product_ID=@ma and Stock_ID=@makhonhan
	update INVENTORY_DETAIL set Quantity= Quantity- @soluong where Product_ID=@ma and Stock_ID=@makhoxuat
end
go
create trigger CapNhatSoLuong_STOCK_TRANSFER_DETAIL_Xoa
on STOCK_TRANSFER_DETAIL
for delete,update
as
begin
	declare @soluong int
	declare @ma nvarchar(30)
	declare @makhoxuat nvarchar(30)
	declare @makhonhan nvarchar(30)
	select @ma=i.Product_ID,@makhoxuat=i.OutStock,@makhonhan=i.InStock,@soluong=i.Quantity
	from deleted i
	update INVENTORY_DETAIL set Quantity= Quantity+ @soluong where Product_ID=@ma and Stock_ID=@makhonhan
	update INVENTORY_DETAIL set Quantity= Quantity- @soluong where Product_ID=@ma and Stock_ID=@makhoxuat
end

go

alter function tinhTongTienKhachHang(@ma nvarchar(30))
returns float
as
begin
	declare @sotien float
	select @sotien =SUM( cast(cr.Amount as float))
	from CUSTOMER_RECEIPT cr where @ma=cr.CustomerID
	return @sotien
end

create trigger CapNhatSoTien_KhachHang
on CUSTOMER_RECEIPT
for insert
as
begin
	declare @ma nvarchar(30)
	select @ma=i.CustomerID from inserted i
	update CUSTOMER_RECEIPT set TongTien= dbo.tinhTongTienKhachHang(@ma)
end

alter trigger CapNhatGiaNhap
on STOCK_INWARD_DETAIL
for insert,update,delete
as
begin
	declare @ma nvarchar(30)
	declare @SoLuong int
	declare @SoTien float
	select @ma=i.Product_ID from inserted i
	
	select @SoLuong= sum(cast(s.Quantity as float)) ,@SoTien=sum(cast(s.Quantity as float)*cast(s.UnitPrice as float)) from STOCK_INWARD_DETAIL s
	where @ma=Product_ID
	group by Product_ID
	
	update PRODUCT set AverageCost= @SoTien/@SoLuong where Product_ID=@ma

	
	select @ma=i.Product_ID from deleted i
	
	select @SoLuong= sum(cast(s.Quantity as float)) ,@SoTien=sum(cast(s.Quantity as float)*cast(s.UnitPrice as float)) from STOCK_INWARD_DETAIL s
	where @ma=Product_ID
	group by Product_ID
	
	update PRODUCT set AverageCost= @SoTien/@SoLuong where Product_ID=@ma
end


select * from PRODUCT
select * from STOCK_INWARD_DETAIL


