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
    public class DAL_STOCK : DB_Connect
    {
        public DataTable LayThongTinKhoHang()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM STOCK";
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
        public int ThemKhoHang(DTO_STOCK kv)
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
            cmd.CommandText = "INSERT into  STOCK   VALUES ( '" + kv.Stock_ID + "' ,  '" + kv.Stock_Name + "' ,  N'" + kv.Contact + "' ,  N'" + kv.Address + "' ,  N'" + kv.Email + "' ,  N'" + kv.Telephone + "' ,  '" + kv.Fax + "' ,  '" + kv.Mobi + "' ,  '" + kv.Manager + "',  N'" + kv.Description + "' ,  " + active + ")";
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
        public int XoaKhoHang(string ID)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete STOCK  where Stock_ID= N'" + ID + "'";
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
        public int CapNhatKhoHang(DTO_STOCK kv)
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
            cmd.CommandText = "delete STOCK  where Stock_ID= N'" + kv.Stock_ID + "'  INSERT into  STOCK   VALUES ( '" + kv.Stock_ID + "' ,  '" + kv.Stock_Name + "' ,  N'" + kv.Contact + "' ,  N'" + kv.Address + "' ,  N'" + kv.Email + "' ,  N'" + kv.Telephone + "' ,  '" + kv.Fax + "' ,  '" + kv.Mobi + "' ,  '" + kv.Manager + "',  N'" + kv.Description + "' ,  " + active + ") ";
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
        public DataTable LayThongTinKhoHang(string id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM STOCK where Stock_ID = '" + id + "' ";
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
