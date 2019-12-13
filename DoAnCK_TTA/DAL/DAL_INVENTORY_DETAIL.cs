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
    public class DAL_INVENTORY_DETAIL:DB_Connect
    {
        public DataTable LayDanhCachPhieuNhapHang()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select i.Product_ID,p.Product_Name,u.Unit_Name,i.Quantity,g.ProductGroup_Name,s.Stock_Name  from INVENTORY_DETAIL i , PRODUCT p left join  PRODUCT_GROUP g on p.Product_Group_ID = g.ProductGroup_ID ,STOCK s, UNIT u  where i.Product_ID = p.Product_ID and u.Unit_ID = p.Unit and i.Stock_ID = s.Stock_ID group By i.Product_ID,p.Product_Name,u.Unit_Name,i.Quantity,g.ProductGroup_Name,s.Stock_Name ";
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
        public int ThemPhieuNhapHang(DTO_INVENTORY_DETAIL kv)
        {
            int a;
            if (kv.Sorted == null)
                a = 1;
            else
                a = int.Parse(kv.Sorted);

            double id = double.Parse(kv.ID);

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into  INVENTORY_DETAIL   VALUES (" + id + ",N'" + kv.RefNo + "',N'" + kv.RefDate + "','',N'" + kv.RefType + "',N'" + kv.RefStatus + "',N'" + kv.StoreID + "',N'" + kv.Stock_ID + "',N'" + kv.Product_ID + "',N'" + kv.Product_Name + "',N'" + kv.Customer_ID + "',N'" + kv.Employee_ID + "',N'" + kv.Batch + "',N'" + kv.Serial + "',N'" + kv.Unit+"',"  + float.Parse(kv.Price) + "," + float.Parse(kv.Quantity) + "," + float.Parse(kv.UnitPrice) + "," + float.Parse(kv.Amount) + "," + float.Parse(kv.E_Qty) + "," + float.Parse(kv.E_Amt)+ ",N'" + kv.Description + "',0,0" +")";

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
            return 1;

        }
      
    }
}
