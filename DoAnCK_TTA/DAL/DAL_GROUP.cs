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
    public class DAL_GROUP : DB_Connect
    {
        public DataTable LayThongTinPhanQuyenbyName(string group)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.SYS_GROUP g where g.Group_Name = N'" + group + "'"; 
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinPhanQuyenbyID(string group)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.SYS_GROUP g where g.Group_ID = N'" + group + "'";
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
            cmd.CommandText = "select Group_ID,UserName,UserName as GroupID from SYS_User union select Description,Group_Name, Group_ID from SYS_GROUP";
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
        public DataTable LayThongTinGroup()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Description,Group_Name, Group_ID,Active from SYS_GROUP";
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
        public int ThemThongTinVaiTro(DTO_GROUP g)
        {
            int active;
            if (g.Active)
                active = 1;
            else
                active = 0;

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete  SYS_GROUP where Group_ID=N'"+ g.Group_ID + "'     INSERT [dbo].[SYS_GROUP] ([Group_ID], [Group_Name], [Group_NameEn], [Description], [Active]) VALUES ('" + g.Group_ID+"', N'"+g.Group_Name+"', N'', N'"+g.Description+"', "+active+")";
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
