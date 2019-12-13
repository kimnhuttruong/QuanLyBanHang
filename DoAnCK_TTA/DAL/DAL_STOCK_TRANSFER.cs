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
    class DAL_STOCK_TRANSFER : DB_Connect
    {
        //public int ThemPhieuNhapHang(DTO_STOCK_TRANSFER kv)
        //{
           
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = _conn;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "INSERT into  STOCK_TRANSFER (ID  ,Transfer_ID ,Product_ID,RefStatus ,PaymentMethod ,TermID  ,PaymentDate  ,Barcode ,Employee_ID  ,Stock_ID,Customer_ID,CustomerName,CustomerAddress,Payment,Vat,VatAmount,Amount,FAmount ,Charge,Description , DeliveryDate) " +
        //                                      " VALUES (N'" + kv.ID + "','" + kv.RefDate + "','" + kv.Ref_OrgNo + "','" + kv.RefStatus + "','" + kv.PaymentMethod + "','" + kv.TermID + "',N'" + kv.PaymentDate + "',N'" + kv.Barcode + "',N'" + kv.Employee_ID + "',N'" + kv.Stock_ID + "',N'" + kv.Customer_ID + "',N'" + kv.CustomerName + "',N'" + kv.CustomerAddress + "',N'" + kv.Payment + "',N'" + kv.Vat + "',N'" + kv.VatAmount + "',N'" + kv.Amount + "',N'" + kv.FAmount + "',N'" + kv.Charge + "',N'" + kv.Description + "',N'" + kv.DeliveryDate + "')";
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
        //public DataTable LayThongTinBangKeChiTiet()
        //{
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = _conn;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select s.* from STOCK_TRANSFER s";
        //    try
        //    {
        //        OpenConnection();
        //        da.SelectCommand = cmd;
        //        da.Fill(dt);
        //        CloseConnection();
        //        return dt;
        //    }
        //    catch
        //    {
        //        return dt;
        //    }
        //}
        //public DataTable LayThongTinBangKeChiTiet(string ma)
        //{
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = _conn;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select s.* from STOCK_TRANSFER s where s.Barcode='" + ma + "'";
        //    try
        //    {
        //        OpenConnection();
        //        da.SelectCommand = cmd;
        //        da.Fill(dt);
        //        CloseConnection();
        //        return dt;
        //    }
        //    catch
        //    {
        //        return dt;
        //    }
        //}
    }
}
