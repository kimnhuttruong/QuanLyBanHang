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
    public class DAL_PRODUCT_GROUP:DB_Connect
    {
        public int ThemNhomHang(DTO_PRODUCT_GROUP kv)
        {
            int active;
            if (kv.Active)
                active = 1;
            else
                active = 0;
            int main;
            if (kv.IsMain)
                main = 1;
            else
                main = 0;

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into PRODUCT_GROUP (ProductGroup_ID, ProductGroup_Name, Description,IsMain, Active ) VALUES (N'" + kv.ProductGroup_ID + "', N'" + kv.ProductGroup_Name + "', N'" + kv.Description + "', " + main + ", " + active + ")";
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
        public int XoaNhomHang(string ID)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete [dbo].[PRODUCT_GROUP] where ProductGroup_ID= N'" + ID + "'";
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
        public int CapNhatNhomHang(DTO_PRODUCT_GROUP kv)
        {
            int active;
            if (kv.Active)
                active = 1;
            else
                active = 0;
            int main;
            if (kv.IsMain)
                main = 1;
            else
                main = 0;

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update [dbo].[PRODUCT_GROUP] set ProductGroup_Name = N'" + kv.ProductGroup_Name + "' , Description = N'" + kv.Description + "'  , Active = " + active +"  , IsMain = " + main + " where ProductGroup_ID = '" + kv.ProductGroup_ID + "'";
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
        public DataTable LayDanhSachNhomHang()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PRODUCT_GROUP";
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
        public DataTable LayThongTinNhomHang(string id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Product_Group where ProductGroup_ID = '" + id + "' ";
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
