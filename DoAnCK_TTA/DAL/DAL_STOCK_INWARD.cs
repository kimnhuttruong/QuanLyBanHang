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
    public class DAL_STOCK_INWARD : DB_Connect
    {
        public int ThemPhieuNhapHang(DTO_STOCK_INWARD kv)
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
            cmd.CommandText = "INSERT into  STOCK_INWARD (ID  ,RefDate ,Ref_OrgNo,RefStatus ,PaymentMethod ,TermID  ,PaymentDate  ,Barcode ,Employee_ID  ,Stock_ID,Customer_ID,CustomerName,CustomerAddress,Payment,Vat,VatAmount,Amount,FAmount ,Charge,Description , DeliveryDate) " +
                                              " VALUES (N'" + kv.ID+"','"+kv.RefDate+ "','" + kv.Ref_OrgNo + "','" + kv.RefStatus + "','" + kv.PaymentMethod+"','"+kv.TermID+"',N'"+kv.PaymentDate+"',N'"+kv.Barcode+"',N'"+kv.Employee_ID+"',N'"+kv.Stock_ID+"',N'"+kv.Customer_ID+"',N'"+kv.CustomerName+"',N'"+kv.CustomerAddress+"',N'"+kv.Payment+"',N'"+kv.Vat+"',N'"+kv.VatAmount+"',N'"+kv.Amount+"',N'"+kv.FAmount+"',N'"+kv.Charge+"',N'"+kv.Description+"',N'"+kv.DeliveryDate+"')";
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
        public DataTable LayThongTinBangKeChiTiet()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.* from STOCK_INWARD s";
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
            cmd.CommandText = "select s.* from STOCK_INWARD s where s.Barcode='"+ma+"'";
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
        public DataTable LayThongTinBangKe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID,si.RefDate,N'Phiếu Mua' as LoaiPhieu,Charge,si.Description from STOCK_INWARD si union select ID,si.RefDate,N'Phiếu Bán' as LoaiPhieu,Charge,si.Description from STOCK_OUTWARD si union select si.Transfer_ID,si.QtyConvert,N'Phiếu Chuyển Kho' as LoaiPhieu,Sum(cast(si.Amount as float)),si.Description from STOCK_TRANSFER_DETAIL si group by si.Transfer_ID,si.QtyConvert,si.Description";
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
                                                                                                                                                                                     
                                                                                                                                                                                     
                                                                                                                                                                                     
                                                                                                                                                                                     
                                                                                                                                                                                     
                                                                                                                                                                                     
                                                                                                                                                                                     