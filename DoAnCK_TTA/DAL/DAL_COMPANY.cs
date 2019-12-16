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
    public class DAL_COMPANY:DB_Connect
    {
        public int ThemCongTy(DTO_COMPANY kv)
        {
            
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  COMPANY        INSERT into COMPANY  VALUES (N'" + kv.CompanyID + "', N'" + kv.CompamyName + "', N'" + kv.CompanyAddress + "', N'" + kv.Tel + "', N'" + kv.CompanyTax + "', N'" + kv.Fax + "', N'" + kv.WebSite + "', N'" + kv.Email + "', N'" + kv.Logo + "')";
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
        public DataTable LayDanhSachCongTy()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM COMPANY";
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
