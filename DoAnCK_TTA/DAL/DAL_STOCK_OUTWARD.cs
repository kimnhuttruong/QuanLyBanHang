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
            if (kv.Active1)
                active = 1;
            else
                active = 0;



            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.STOCK_OUTWARD" + " VALUES (N'" + kv.ID1 + "'"
                        + ",N'" + kv.RefStatus1 + "'"
                        + ",N'" + kv.PaymentMethod1 + "'"
                        + ",N'" + kv.PaymentDate1 + "'"
                        + ",N'" + kv.Department_ID1 + "'"
                        + ",N'" + kv.Employee_ID1 + "'"
                        + ",N'" + kv.Stock_ID1 + "'"
                        + ",N'" + kv.Customer_ID1 + "'"
                        + ",N'" + kv.CustomerName1 + "'"
                        + ",N'" + kv.CustomerAddress1 + "'"
                        + ",N'" + kv.Contact1 + "'"
                        + ",N'" + kv.Payment1 + "'"
                        + ",N'" + kv.Currency_ID1 + "'"
                        + ",N'" + kv.ExchangeRate1 + "'"
                        + ",N'" + kv.Vat1 + "'"
                        + ",N'" + kv.VatAmount1 + "'"
                        + ",N'" + kv.Amount1 + "'"
                        + ",N'" + kv.FAmount1 + "'"
                        + ",N'" + kv.DiscountDate1 + "'"
                        + ",N'" + kv.DiscountRate1 + "'"
                        + ",N'" + kv.Discount1 + "'"
                        + ",N'" + kv.OtherDiscount1 + "'"
                        + ",N'" + kv.OtherDiscount1 + "'"
                        + ",N'" + kv.Charge1 + "'"
                        + ",N'" + kv.User_ID1 + "'"
                        + ",N'" + kv.IsClose1 + "'"
                        + ",N'" + kv.Description1 + "'"
                        + "," + active + ")";

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
            return 1;


        }
    }
}
