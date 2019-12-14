using DoAnCK_TTA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DAL
{
    public class DAL_STOCK_OUTWARD_DETAIL :DB_Connect
    {
        public int ThemPhieuXuatHang(DTO_STOCK_OUTWARD_DETAIL kv)
        {
            int active;
            if (kv.Active)
                active = 1;
            else
                active = 0;


            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into  STOCK_OUTWARD_DETAIL (ID  ,Outward_ID ,Product_ID,ProductName ,Unit ,Stock_ID  ,Amount  ,UnitPrice ,Charge  ,Quantity ,Discount,DiscountRate,Description) " +
                                              " VALUES (N'" + kv.ID + "','" + kv.Outward_ID + "','" + kv.Product_ID + "',N'" + kv.ProductName + "','" + kv.Unit + "','" + kv.Stock_ID + "',N'" + kv.Amount + "',N'" + kv.UnitPrice + "',N'" + kv.Charge + "',N'" + kv.Quantity + "',N'" + kv.Discount + "',N'" + kv.DiscountRate + "',N'" + kv.Description + "')";
            //try
            //{
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
                return 1;
            //}
            //catch
            //{
            //    return 0;
            //}
        }
        public int XoaPhieuXuatHang(string ma, string mahang, string Quantity)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete STOCK_OUTWARD_DETAIL where  Outward_ID='" + ma + "' and Product_ID='" + mahang + "' and Quantity='" + Quantity + "'";
            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable LayThongTinBangKe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.Outward_ID,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,s.Customer_ID,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit,d.Discount,d.DiscountRate,d.Quantity*d.UnitPrice*(1-d.Discount) as Tien , 0 as Tra,d.Description from STOCK_OUTWARD s ,STOCK_OUTWARD_DETAIL d ,PRODUCT p, STOCK st where s.ID=d.Outward_ID and st.Stock_ID=d.Stock_ID  and p.Product_ID=d.Product_ID";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinCongNoChiTiet()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.Outward_ID,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,s.Customer_ID,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit,d.Discount,d.DiscountRate,d.Quantity*d.UnitPrice*(1-d.Discount) as Tien , 0 as Tra,d.Description from STOCK_OUTWARD s ,STOCK_OUTWARD_DETAIL d ,PRODUCT p, STOCK st where s.ID=d.Outward_ID and st.Stock_ID=d.Stock_ID  and p.Product_ID=d.Product_ID and s.TermID='CN'";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinThanhToanNgayChiTiet()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.Outward_ID,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,s.Customer_ID,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit,d.Discount,d.DiscountRate,d.Quantity*d.UnitPrice*(1-d.Discount) as Tien , 0 as Tra,d.Description from STOCK_OUTWARD s ,STOCK_OUTWARD_DETAIL d ,PRODUCT p, STOCK st where s.ID=d.Outward_ID and st.Stock_ID=d.Stock_ID  and p.Product_ID=d.Product_ID and s.TermID='TM'";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinBangKeChiTiet()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.Outward_ID,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,s.Customer_ID,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit,d.Discount,d.DiscountRate,d.Quantity*d.UnitPrice*(1-d.Discount) as Tien , 0 as Tra,d.Description from STOCK_OUTWARD s ,STOCK_OUTWARD_DETAIL d ,PRODUCT p, STOCK s.ID=d.Outward_ID and st where st.Stock_ID=d.Stock_ID  and p.Product_ID=d.Product_ID";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinBangKeChiTiet(string ma)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.Outward_ID ,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit ,d.Discount,d.DiscountRate,d.Quantity*d.UnitPrice*(1-d.Discount) as Tien , 0 as Tra,d.Description from STOCK_OUTWARD s ,STOCK_OUTWARD_DETAIL d ,PRODUCT p, STOCK st where st.Stock_ID=s.Stock_ID  and p.Product_ID=d.Product_ID and d.Outward_ID='" + ma + "' ";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinBangKeChiTietDataTable(string ma)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.Outward_ID as Ma,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit from STOCK_OUTWARD s ,STOCK_OUTWARD_DETAIL d ,PRODUCT p, STOCK st where st.Stock_ID=s.Stock_ID and s.ID = d.ID and p.Product_ID=d.Product_ID and d.Outward_ID='" + ma + "' ";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinMuaHangTheoKH()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select so.Customer_ID,so.CustomerName,cg.Customer_Group_Name,sum(distinct(cast((sod.amount) as float))) as TienBan from STOCK_OUTWARD_DETAIL sod,STOCK_OUTWARD so, CUSTOMER_GROUP cg,CUSTOMER p where sod.OUTward_ID = so.ID  and p.Customer_Group_ID = cg.Customer_Group_ID  and so.Customer_ID = p.Customer_ID group by so.Customer_ID,so.CustomerName,cg.Customer_Group_Name";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinLoiNhuan()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select so.CustomerName ,sod.Outward_ID,so.RefDate,sod.Product_ID,p.Product_Name,sod.Unit,sod.Quantity,p.AverageCost,cast(sod.Quantity as float)*cast(p.AverageCost as float)as TTienNhap,sod.UnitPrice,cast(sod.Quantity as float)*cast(sod.UnitPrice as float)as TTienXuat,cast(sod.Quantity as float)*(cast(sod.UnitPrice as float) -cast(p.AverageCost as float)) as ChenhLech,so.FAmount,so.VatAmount from STOCK_OUTWARD_DETAIL sod,STOCK_OUTWARD so, PRODUCT p  where sod.Outward_ID = so.id and sod.Product_ID = p.Product_ID";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinLoiNhuanTheoHangHoa()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select st.Stock_Name,sod.Product_ID,p.Product_Name,sod.Unit,pg.ProductGroup_Name,Sum(cast(sod.Quantity as float)) as SoLuong,Sum(cast(sod.Quantity as float)*cast(sod.UnitPrice as float))as TTienXuat,p.AverageCost,Sum(cast(sod.Quantity as float)*cast(p.AverageCost as float))as TTienNhap from STOCK_OUTWARD_DETAIL sod,STOCK_OUTWARD so, PRODUCT p,STOCK st, PRODUCT_GROUP pg  where sod.Outward_ID = so.id and sod.Product_ID = p.Product_ID and sod.Stock_ID = st.Stock_ID and pg.ProductGroup_ID = p.Product_Group_ID group by st.Stock_Name,sod.Product_ID,p.Product_Name,sod.Unit,pg.ProductGroup_Name,p.AverageCost ";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
    }
}

