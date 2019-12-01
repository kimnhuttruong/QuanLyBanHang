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
    public class DAL_UNIT:DB_Connect
    {
        public int ThemDonViTinh(DTO_UNIT kv)
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
            cmd.CommandText = "INSERT into UNIT (Unit_ID, Unit_Name, Description, Active ) VALUES (N'" + kv.Unit_ID + "', N'" + kv.Unit_Name + "', N'" + kv.Description + "', " + active + ")";
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
        public int XoaDonViTinh(string ID)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete [dbo].[UNIT] where Unit_ID= N'" + ID + "'";
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
        public int CapNhatDonViTinh(DTO_UNIT kv)
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
            cmd.CommandText = "Update [dbo].[UNIT] set Unit_Name = N'" + kv.Unit_Name + "' , Description = N'" + kv.Description + "'  , Active = " + active + " where Customer_Group_ID = '" + kv.Unit_ID + "'";
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
        public DataTable LayDanhSachDonViTinh()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM UNIT";
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
        public DataTable LayThongTinDonViTinh(string id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Unit where Unit_ID = '" + id + "' ";
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
