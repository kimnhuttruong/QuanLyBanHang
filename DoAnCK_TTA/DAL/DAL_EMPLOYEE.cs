using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DAL
{
    public class DAL_EMPLOYEE:DB_Connect
    {
        DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
        public DataTable LayThongTinNhanVien()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Employee_ID,Employee_Name,[Department_Name] from EMPLOYEE e join DEPARTMENT d on d.Department_ID = e.Department_ID";
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
        public DataTable LayDanhSachQuanLy()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Employee_ID ,Employee_Name from EMPLOYEE";
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
            cmd.CommandText = "INSERT INTO dbo.EMPLOYEE(Employee_ID,Employee_Name,Department_ID,Address,Mobile,Manager_ID,Active) VALUES('" + g.Employee_ID1 + "','" + g.Employee_Name1 + "','" + g.Department_ID1 + "','" + g.Address1 + "','" + g.Mobile1 + "','" + g.Manager_ID1 + "',true)	";
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

    }
}
