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
    public class DAL_STOCK_INWARD_DETAIL: DB_Connect
    {
        public int ThemPhieuNhapHang(DTO_STOCK_INWARD_DETAIL kv)
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
            cmd.CommandText = "   INSERT into  STOCK_INWARD_DETAIL (ID  ,Inward_ID ,Product_ID,ProductName ,Unit ,Stock_ID  ,Amount  ,UnitPrice ,Charge  ,Quantity ) " +
                                              " VALUES (N'" + kv.ID + "','" + kv.Inward_ID + "','" + kv.Product_ID + "',N'" + kv.ProductName + "','" + kv.Unit + "','" + kv.Stock_ID + "',N'" + kv.Amount + "',N'" + kv.UnitPrice + "',N'" + kv.Charge + "',N'" + kv.Quantity + "')";
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
        public int XoaFullPhieuNhapHang(string kv)
        {
          


            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete STOCK_INWARD_DETAIL where Inward_ID='" + kv + "'  ";
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
        public int XoaPhieuNhapHang(string ma,string mahang,string Quantity)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete STOCK_INWARD_DETAIL where  Inward_ID='"+ma+ "' and Product_ID='"+mahang+ "' and Quantity='"+ Quantity + "'";
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
            cmd.CommandText = "select d.Inward_ID,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit,d.Amount from STOCK_INWARD s ,STOCK_INWARD_DETAIL d ,PRODUCT p, STOCK st where st.Stock_ID=s.Stock_ID and s.ID = d.Inward_ID and p.Product_ID=d.Product_ID";
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
        public DataTable LayThongTinMuaHangTheoNgay()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select si.RefDate, Sum(cast(sid.amount as float)) as TienMua,Sum(cast(isnull(sod.amount,0) as float))/count(sod.amount) as TienBan from STOCK_INWARD_DETAIL sid,STOCK_INWARD si,STOCK_OUTWARD_DETAIL sod,STOCK_OUTWARD so where sid.Inward_ID = si.ID  and sod.Outward_ID = so.ID group by si.RefDate";
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
        public DataTable LayThongTinMuaHangTheoNCC()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select si.Customer_ID,si.CustomerName,cg.Customer_Group_Name,sum(distinct(cast((sid.amount) as float))) as TienMua from STOCK_INWARD_DETAIL sid,STOCK_INWARD si,CUSTOMER_GROUP cg,PROVIDER p where sid.Inward_ID = si.ID  and p.Customer_Group_ID = cg.Customer_Group_ID  and si.Customer_ID = p.Customer_ID group by si.Customer_ID,si.CustomerName,cg.Customer_Group_Name";
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
        public DataTable LayThongTinBangKeCongNo()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.Inward_ID,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,s.Customer_ID,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit,d.Amount ,cast(d.Quantity as float)*cast(d.UnitPrice as float) as Tien , 0 as Tra,d.Description   from STOCK_INWARD s ,STOCK_INWARD_DETAIL d ,PRODUCT p, STOCK st where st.Stock_ID=s.Stock_ID and s.ID = d.Inward_ID and p.Product_ID=d.Product_ID and s.TermID='CN' ";
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
        public DataTable LayThongTinBangKeThanhToanNgay()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.Inward_ID,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,s.Customer_ID,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit,d.Amount ,cast(d.Quantity as float)*cast(d.UnitPrice as float) as Tien , 0 as Tra,d.Description   from STOCK_INWARD s ,STOCK_INWARD_DETAIL d ,PRODUCT p, STOCK st where st.Stock_ID=s.Stock_ID and s.ID = d.Inward_ID and p.Product_ID=d.Product_ID and s.TermID='TM' ";
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
            cmd.CommandText = "select d.Inward_ID ,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit ,s.Charge , 0 as Tra,d.Description  from STOCK_INWARD s ,STOCK_INWARD_DETAIL d ,PRODUCT p, STOCK st where st.Stock_ID=s.Stock_ID and s.ID = d.Inward_ID and p.Product_ID=d.Product_ID and d.Inward_ID='" + ma+"' ";
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
            cmd.CommandText = "select d.Inward_ID as Ma,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit,s.Vat,s.VatAmount,s.Amount,s.FAmount,d.Amount as Tong from STOCK_INWARD s ,STOCK_INWARD_DETAIL d ,PRODUCT p, STOCK st where st.Stock_ID=s.Stock_ID  and s.Barcode=d.Inward_ID   and p.Product_ID=d.Product_ID and d.Inward_ID='" + ma + "' ";
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
