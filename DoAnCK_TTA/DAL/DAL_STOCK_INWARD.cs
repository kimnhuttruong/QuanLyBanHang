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
            cmd.CommandText = "INSERT into  INVENTORY_DETAIL   VALUES (N'"+kv.ID+"',N'"+kv.RefDate+"',1,1,1,N'"+kv.PaymentMethod+"',N'"+kv.TermID+"',N'"+kv.PaymentDate+"',N'"+kv.DeliveryDate+"',N'"+kv.Barcode+"',N'"+kv.Department_ID+"',N'"+kv.Employee_ID+"',N'"+kv.Stock_ID+"',N'"+kv.Branch_ID+"',N'"+kv.Contract_ID+"',N'"+kv.Customer_ID+"',N'"+kv.CustomerName+"',N'"+kv.CustomerAddress+"',N'"+kv.Contact+"',N'"+kv.Reason+"',N'"+kv.Payment+"',N'"+kv.Currency_ID+"',N'"+kv.ExchangeRate+"',N'"+kv.Vat+"',N'"+kv.VatAmount+"',N'"+kv.Amount+"',N'"+kv.FAmount+"',N'"+kv.DiscountDate+"',N'"+kv.DiscountRate+"',N'"+kv.Discount+"',N'"+kv.OtherDiscount+"',N'"+kv.Charge+"',N'"+kv.IsClose+"',N'"+kv.Description+"',N'"+kv.Sorted+"',N'"+kv.User_ID+"',"+active+",N'"+kv.Timestamp+"')";
    
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
            return 1;


        }
    }
}
