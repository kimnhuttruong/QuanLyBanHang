using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.DAL
{
    public class DAL_PRODUCT:DB_Connect
    {
        public int ThemHangHoa(DTO_PRODUCT kv)
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
            cmd.CommandText = "INSERT into  PRODUCT   VALUES (N'"+kv.Product_ID+"', N'"+kv.Product_Name+"', N'"+kv.Product_NameEN+"', N'"+kv.Product_Type_ID+"', N'"+kv.Manufacturer_ID+"', N'"+kv.Model_ID+"', N'"+kv.Product_Group_ID+"', N'"+kv.Provider_ID+"', N'"+kv.Origin+"', N'"+kv.Barcode+"', N'"+kv.Unit+"', N'"+kv.UnitConvert+"', N'"+kv.UnitRate+"', N'"+kv.Org_Price+"', N'"+kv.Sale_Price+"', N'"+kv.Retail_Price+"', N'"+kv.Quantity+"', N'"+kv.CurrentCost+"', N'"+kv.AverageCost+"', N'"+kv.Warranty+"', N'"+kv.VAT_ID+"', N'"+kv.ImportTax_ID+"', N'"+kv.ExportTax_ID+"', N'"+kv.LuxuryTax_ID+"', N'"+kv.Customer_ID+"', N'"+kv.Customer_Name+"', N'"+kv.CostMethod+"', N'"+kv.MinStock+"', N'"+kv.MaxStock+"', N'"+kv.Discount+"', N'"+kv.Commission+"', N'"+kv.Description+"', N'"+kv.Color+"', N'"+kv.Expiry+"', N'"+kv.LimitOrders+"', N'"+kv.ExpiryValue+"', N'"+kv.Batch+"', N'"+kv.Depth+"', N'"+kv.Height+"', N'"+kv.Width+"', N'"+kv.Thickness+"', N'"+kv.Size+"',  N'"+kv.Currency_ID+"', N'"+kv.ExchangeRate+"', N'"+kv.Stock_ID+"', N'"+kv.UserID+"', N'"+kv.Serial+"', "+active+ ",N'" + kv.Photo + "')";
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
        public int XoaHangHoa(string ID)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete PRODUCT  where Product_ID= N'" + ID + "' ";
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
        public int CapNhatHangHoa(DTO_PRODUCT kv)
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
            cmd.CommandText = "delete PRODUCT  where Product_ID= N'" + kv.Product_ID + "'   INSERT into  PRODUCT   VALUES (N'" + kv.Product_ID + "', N'" + kv.Product_Name + "', N'" + kv.Product_NameEN + "', N'" + kv.Product_Type_ID + "', N'" + kv.Manufacturer_ID + "', N'" + kv.Model_ID + "', N'" + kv.Product_Group_ID + "', N'" + kv.Provider_ID + "', N'" + kv.Origin + "', N'" + kv.Barcode + "', N'" + kv.Unit + "', N'" + kv.UnitConvert + "', N'" + kv.UnitRate + "', N'" + kv.Org_Price + "', N'" + kv.Sale_Price + "', N'" + kv.Retail_Price + "', N'" + kv.Quantity + "', N'" + kv.CurrentCost + "', N'" + kv.AverageCost + "', N'" + kv.Warranty + "', N'" + kv.VAT_ID + "', N'" + kv.ImportTax_ID + "', N'" + kv.ExportTax_ID + "', N'" + kv.LuxuryTax_ID + "', N'" + kv.Customer_ID + "', N'" + kv.Customer_Name + "', N'" + kv.CostMethod + "', N'" + kv.MinStock + "', N'" + kv.MaxStock + "', N'" + kv.Discount + "', N'" + kv.Commission + "', N'" + kv.Description + "', N'" + kv.Color + "', N'" + kv.Expiry + "', N'" + kv.LimitOrders + "', N'" + kv.ExpiryValue + "', N'" + kv.Batch + "', N'" + kv.Depth + "', N'" + kv.Height + "', N'" + kv.Width + "', N'" + kv.Thickness + "', N'" + kv.Size + "',  N'" + kv.Currency_ID + "', N'" + kv.ExchangeRate + "', N'" + kv.Stock_ID + "', N'" + kv.UserID + "', N'" + kv.Serial + "', " + active + ",N'" + kv.Photo + "')";
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
        public DataTable LayDanhSachHangHoa()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT p.*,s.Stock_Name,g.ProductGroup_Name FROM PRODUCT p left join Stock s on p.Stock_ID = s.Stock_ID left join  PRODUCT_GROUP g on g.ProductGroup_ID = p.Product_Group_ID";
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
        public DataTable LayThongTinHangHoa(string id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PRODUCT where Product_ID = '" + id + "' ";
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
