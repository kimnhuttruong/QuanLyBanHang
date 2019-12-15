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
    public class DAL_SYS_USER:DB_Connect
    {
        public bool LayDanhSachPhanQuyen(string username, string password)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SYS_USER where UserName='" + username + "' and Password='" + password + "'";
            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
        public DataTable LayThongTinPhanQuyen(string Group_ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select UserName, g.Group_Name,u.Description,u.Active,g.Group_Name,g.Group_ID from SYS_USER u join SYS_GROUP g on u.Group_ID = g.Group_ID where g.Group_ID = '" + Group_ID + "'";
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
        public DataTable LayThongTinVaiTro()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT UserName,Group_ID FROM dbo.SYS_USER";
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
        public int ThemNguoiDung(DTO_SYS_USER u)
        {
            int active;
            if (u.Active)
                active = 1;
            else
                active = 0;
            string ma= DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "").Replace("AM", "").Replace("PM", "");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT [dbo].[SYS_USER] VALUES ('" + ma + "', N'" + u.UserName + "', N'"+u.Password+"', N'" +u.Group_ID+"',N'',N'',"+ active + ",'"+u.Employee_ID+"')";
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
        public int CapNhatNhom(string u)
        {
           
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "  declare @nhom nvarchar(30) select @nhom = u.Group_ID from SYS_USER u where u.UserName = N'"+u+"'  update FOrm set Description = @nhom";
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
    }
}
