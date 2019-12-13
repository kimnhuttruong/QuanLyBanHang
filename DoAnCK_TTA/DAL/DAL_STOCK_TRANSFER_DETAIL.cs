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
    class DAL_STOCK_TRANSFER_DETAIL :DB_Connect
    {

        public int ThemPhieuNhapHang(DTO_STOCK_TRANSFER_DETAIL kv)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into  STOCK_TRANSFER_DETAIL (ID  ,Transfer_ID ,Product_ID,Product_Name ,OutStock ,OutStockName  ,InStock  ,InStockName ,Unit  ,UnitPrice,Quantity,Description,Amount,QtyConvert) " +
                                             " VALUES (N'" + kv.ID + "'  ,N'" + kv.Transfer_ID + "' ,N'" + kv.Product_ID + "' ,N'" + kv.Product_Name + "' ,N'" + kv.OutStock + "'  ,N'" + kv.OutStockName + "'  ,N'" + kv.InStock + "'  ,N'" + kv.InStockName + "' ,N'" + kv.Unit + "'  ,N'" + kv.UnitPrice + "' ,N'" + kv.Quantity + "' ,N'" + kv.Description + "' ,N'" + kv.Amount + "',N'" + kv.QtyConvert + "' )";
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
        public DataTable LayThongTinBangKeChiTiet()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.* from STOCK_TRANSFER_DETAIL s";
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
            cmd.CommandText = "select s.* from STOCK_TRANSFER_DETAIL s where s.Barcode='" + ma + "'";
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
