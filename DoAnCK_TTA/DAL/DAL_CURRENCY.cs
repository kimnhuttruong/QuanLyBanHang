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
    public class DAL_CURRENCY : DB_Connect
    {
        public int ThemTyGia(DTO_CURRENCY kv)
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
            cmd.CommandText = "INSERT into CURRENCY (Currency_ID, CurrencyName, Exchange, Active ) VALUES (N'" + kv.Currency_ID + "', N'" + kv.CurrencyName + "', N'" + kv.Exchange + "', " + active + ")";
            Console.WriteLine(cmd.CommandText);
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
        public int XoaTyGia(string ID)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete [dbo].[CURRENCY] where Currency_ID= N'" + ID + "'";
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
        public int CapNhatTyGia(DTO_CURRENCY kv)
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
            cmd.CommandText = "Update [dbo].[CURRENCY] set CurrencyName = N'" + kv.CurrencyName + "' , Exchange = N'" + kv.Exchange + "'  , Active = " + active + " where Currency_ID = '" + kv.Currency_ID + "'";
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
        public DataTable LayDanhSachTyGia()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CURRENCY";
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
        public DataTable LayThongTinTyGia(string id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CURRENCY where Currency_ID = '" + id + "' ";
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
