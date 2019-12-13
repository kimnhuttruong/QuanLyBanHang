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
    public class DAL_STOCK_OUTWARD:DB_Connect
    {
        public int ThemPhieuXuatHang(DTO_STOCK_OUTWARD kv)
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
            cmd.CommandText =  @"INSERT into  STOCK_OUTWARD (ID, RefDate, Ref_OrgNo, RefStatus, PaymentMethod, TermID, PaymentDate, Barcode, Employee_ID, Stock_ID, Customer_ID, CustomerName, CustomerAddress, Payment, Vat, VatAmount, Amount, FAmount, Charge, Description) " +
                                              " VALUES (N'" + kv.ID + "','" + kv.RefDate + "','" + kv.Ref_OrgNo + "','" + kv.RefStatus + "','" + kv.PaymentMethod + "','" + kv.TermID + "',N'" + kv.PaymentDate + "',N'" + kv.Barcode + "',N'" + kv.Employee_ID + "',N'" + kv.Stock_ID + "',N'" + kv.Customer_ID + "',N'" + kv.CustomerName + "',N'" + kv.CustomerAddress + "',N'" + kv.Payment + "',N'" + kv.Vat + "',N'" + kv.VatAmount + "',N'" + kv.Amount + "',N'" + kv.FAmount + "',N'" + kv.Charge + "',N'" + kv.Description + "')";
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
            return 1;


        }
        public DataTable LayThongTinBangKeChiTiet()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.* from STOCK_OUTWARD s";
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
        public DataTable LayThongTinBangKeChiTiet(string ma)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.* from STOCK_OUTWARD s where s.Barcode='" + ma + "'";
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
