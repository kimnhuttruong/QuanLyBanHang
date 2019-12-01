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
    public class DAL_EMPLOYEE:DB_Connect
    {
        //DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
        public int ThemNhanVien(DTO_EMPLOYEE kv)
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
            cmd.CommandText = "INSERT into EMPLOYEE  VALUES (N'"+ kv.Employee_ID+"', N'"+ kv.FirtName+"', N'"+ kv.LastName+"', N'"+ kv.Employee_Name+"', N'"+ kv.Alias+"', N'"+ kv.Sex+"', N'"+ kv.Address+"', N'"+ kv.Country_ID+"', N'"+ kv.H_Tel+"', N'"+ kv.O_Tel+"', N'"+ kv.Mobile+"', N'"+ kv.Fax+"', N'"+ kv.Email+"', N'"+ kv.Birthday+"', N'"+ kv.Married+"', N'"+ kv.Position_ID+"', N'"+ kv.JobTitle_ID+"', N'"+ kv.Branch_ID+"', N'"+ kv.Department_ID+"', N'"+ kv.Team_ID+"', N'"+ kv.PersonalTax_ID+"', N'"+ kv.City_ID+"', N'"+ kv.District_ID+"', N'"+ kv.Manager_ID+"', N'"+ kv.EmployeeType+"', N'"+ kv.BasicSalary+"', N'"+ kv.Advance+"', N'"+ kv.AdvanceOther+"', N'"+ kv.Commission+"', N'"+ kv.Discount+"', N'"+ kv.ProfitRate+"', N'"+ kv.IsPublic+"', N'"+ kv.CreatedBy+"', N'"+ kv.CreatedDate+"', N'"+ kv.ModifiedBy+"', N'"+ kv.ModifiedDate+"', N'"+ kv.OwnerID+"', N'"+ kv.Description+"', N'"+ kv.Sorted+"', "+active+")";
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
        public int XoaNhanVien(string ID)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete EMPLOYEE where Employee_ID = '" + ID+"'";
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
        public int CapNhatNhanVien(DTO_EMPLOYEE kv)
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
            cmd.CommandText = "delete EMPLOYEE where Employee_ID = '" + kv.Employee_ID + "'    INSERT into EMPLOYEE  VALUES (N'" + kv.Employee_ID + "', N'" + kv.FirtName + "', N'" + kv.LastName + "', N'" + kv.Employee_Name + "', N'" + kv.Alias + "', N'" + kv.Sex + "', N'" + kv.Address + "', N'" + kv.Country_ID + "', N'" + kv.H_Tel + "', N'" + kv.O_Tel + "', N'" + kv.Mobile + "', N'" + kv.Fax + "', N'" + kv.Email + "', N'" + kv.Birthday + "', N'" + kv.Married + "', N'" + kv.Position_ID + "', N'" + kv.JobTitle_ID + "', N'" + kv.Branch_ID + "', N'" + kv.Department_ID + "', N'" + kv.Team_ID + "', N'" + kv.PersonalTax_ID + "', N'" + kv.City_ID + "', N'" + kv.District_ID + "', N'" + kv.Manager_ID + "', N'" + kv.EmployeeType + "', N'" + kv.BasicSalary + "', N'" + kv.Advance + "', N'" + kv.AdvanceOther + "', N'" + kv.Commission + "', N'" + kv.Discount + "', N'" + kv.ProfitRate + "', N'" + kv.IsPublic + "', N'" + kv.CreatedBy + "', N'" + kv.CreatedDate + "', N'" + kv.ModifiedBy + "', N'" + kv.ModifiedDate + "', N'" + kv.OwnerID + "', N'" + kv.Description + "', N'" + kv.Sorted + "', " + active + ") ";
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
        public DataTable LayDanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EMPLOYEE";
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
        public DataTable LayThongTinNhanVien(string id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EMPLOYEE where EMPLOYEE_ID = '" + id + "' ";
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
