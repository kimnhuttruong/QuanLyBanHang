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
    public class DAL_SYS_USER_RULE: DB_Connect
    {
        public DataTable LayDanhSachPhanQuyen(string admin)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Object_Name,u.Object_ID,o.Parent_ID,u.AllowAccess,AllowAdd,AllowDelete,AllowEdit,AllowPrint,AllowExport,AllowImport from SYS_USER_RULE u join SYS_OBJECT o on o.Object_ID = u.Object_ID where u.Goup_ID = '"+admin+"'";
            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public int ThemDanhSachPhanQuyen(DTO_SYS_USER_RULE g)
        {
            

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete SYS_USER_RULE where Goup_ID=N'"+ g.Goup_ID + "' and Object_ID=N'" + g.Object_ID + "'    INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'" + g.Goup_ID+"', N'"+g.Object_ID+ "', N'view', "+ g.AllowAdd+", "+g.AllowDelete+","+ g.AllowEdit+","+ g.AllowAccess+","+ g.AllowPrint+","+ g.AllowExport+","+ g.AllowImport+","+ g.Active+")";
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
        public DataTable LayDanhSachPhanQuyen()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "  declare @ma nvarchar(30) select @ma = Description from Form select u.Object_ID,u.Goup_ID,u.AllowAccess,AllowAdd,AllowDelete,AllowEdit,AllowPrint,AllowExport,AllowImport  from SYS_USER_RULE u where u.Goup_ID = @ma";
            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public DataTable LayDanhSachPhanQuyenButton(string mh)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " declare @ma nvarchar(30) select @ma = Description from Form select AllowAccess  from SYS_USER_RULE u where u.Goup_ID = @ma and Object_ID = N'"+ mh +"'";
            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
