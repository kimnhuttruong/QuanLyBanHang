using DoAnCK_TTA.BUS;
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
    public class DAL_EMPLOYEE : DB_Connect
    {
        public DataTable LayThongTinNhanVien()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Employee_ID,Employee_Name,District_ID,O_Tel,Mobile,Email,Active FROM dbo.EMPLOYEE";
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
                return null;
            }
        }

        public DataTable Detail(string name)
        {
            string sql = " SELECT e.Employee_ID,e.Employee_Name,d.Department_Name,e.Address,e.Mobile,e.Fax,d.Department_Name,e.Manager_ID FROM dbo.EMPLOYEE e JOIN dbo.DEPARTMENT d ON d.Department_ID = e.Department_ID WHERE e.Employee_ID = '" + name + "'";
            return GetData(sql);
        }
        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
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
                return null;
            }
        }
        public int Insert(DTO.DTO_EMPLOYEE g)
        {
      
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.EMPLOYEE(Employee_ID,Employee_Name,Department_ID,Address,Mobile,Manager_ID,Active) VALUES('" + g.Employee_ID1+ "','" + g.Employee_Name1 + "','" + g.Department_ID1 + "','" + g.Address1 + "','" + g.Mobile1 + "','" + g.Manager_ID1 + "',true)	";
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
        public int Exec(string sql)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
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
        //public int update(DTO_EMPLOYEE e)
        //{
        //    int active;
        //    if (g.Active)
        //        active = 1;
        //    else
        //        active = 0;

        //    SqlDataAdapter da = new SqlDataAdapter();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = _conn;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "INSERT [dbo].[SYS_GROUP] ([Group_ID], [Group_Name], [Group_NameEn], [Description], [Active]) VALUES ('" + g.Group_ID + "', N'" + g.Group_Name + "', N'', N'" + g.Description + "', " + active + ")";
        //    try
        //    {
        //        OpenConnection();
        //        cmd.ExecuteNonQuery();
        //        CloseConnection();
        //        return 1;
        //    }
        //    catch
        //    {
        //        return 0;
        //    }

        //}
        //}
    }
}
