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
           public DataTable BaoCaoDoanhSoNhanVien()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select si.Employee_ID,e.Employee_Name,e.Address,e.Mobile, Sum(cast(sid.Quantity as float)*cast(sid.UnitPrice as float)) as TienMua ,BangTam.TienBan from STOCK_INWARD_DETAIL sid,STOCK_INWARD si, EMPLOYEE e join(select so.Employee_ID, e.Employee_Name, e.Address, e.Mobile, Sum(cast(isnull(sod.amount,0) as float)) as TienBan from STOCK_OUTWARD_DETAIL sod,STOCK_OUTWARD so, EMPLOYEE e where sod.outward_ID = so.ID  and so.Employee_ID = e.Employee_ID group by so.Employee_ID,e.Employee_Name,e.Address,e.Mobile) as BangTam on BangTam.Employee_ID = e.Employee_ID where sid.Inward_ID = si.ID  and si.Employee_ID = e.Employee_ID group by si.Employee_ID,e.Employee_Name,e.Address,e.Mobile,BangTam.TienBan";
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
        public DataTable BaoCaoDoanhSoNhanVienChiTiet()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "(select si.Employee_ID,N'Phiếu Mua' as PhieuMua,si.ID,si.RefDate,sid.Product_ID,p.Product_Name,sid.Unit,st.Stock_Name,sid.Quantity,sid.UnitPrice,cast(sid.Quantity as float)*cast(sid.UnitPrice as float) as ThanhTien,si.Amount,si.FAmount,cast(sid.Quantity as float)*cast(sid.UnitPrice as float) -si.FAmount as ThanhToan from STOCK_INWARD_DETAIL sid,STOCK_INWARD si, EMPLOYEE e,PRODUCT p, Stock st where sid.Inward_ID = si.ID and si.Employee_ID = e.Employee_ID and sid.Product_ID = p.Product_ID and st.Stock_ID = sid.Stock_ID) union (select si.Employee_ID, N'Phiếu Bán' as PhieuMua, si.ID, si.RefDate, sid.Product_ID, p.Product_Name, sid.Unit, st.Stock_Name, sid.Quantity, sid.UnitPrice, sid.Amount, sid.Discount, sid.DiscountRate, cast(sid.Quantity as float) * cast(sid.UnitPrice as float) - sid.DiscountRate as ThanhToan from STOCK_OUTWARD_DETAIL sid, STOCK_OUTWARD si, EMPLOYEE e, PRODUCT p, Stock st where sid.Outward_ID = si.ID   and si.Employee_ID = e.Employee_ID and sid.Product_ID = p.Product_ID and st.Stock_ID = sid.Stock_ID)";
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
