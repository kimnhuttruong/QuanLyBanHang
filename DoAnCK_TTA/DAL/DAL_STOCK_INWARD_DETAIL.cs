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
            cmd.CommandText = "INSERT into  STOCK_INWARD_DETAIL (ID  ,Inward_ID ,Product_ID,ProductName ,Unit ,Stock_ID  ,Amount  ,UnitPrice ,Charge  ,Quantity ) " +
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
            cmd.CommandText = "select d.Inward_ID,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit from STOCK_INWARD s ,STOCK_INWARD_DETAIL d ,PRODUCT p, STOCK st where st.Stock_ID=s.Stock_ID and s.ID = d.ID and p.Product_ID=d.Product_ID";
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
            cmd.CommandText = "select d.Inward_ID ,s.RefDate ,p.Product_ID,p.Product_Name,s.CustomerName,st.Stock_Name,d.Quantity,d.UnitPrice, st.Stock_ID, st.Stock_Name,d.Unit from STOCK_INWARD s ,STOCK_INWARD_DETAIL d ,PRODUCT p, STOCK st where st.Stock_ID=s.Stock_ID and s.ID = d.ID and p.Product_ID=d.Product_ID and d.Inward_ID='"+ma+"' ";
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
