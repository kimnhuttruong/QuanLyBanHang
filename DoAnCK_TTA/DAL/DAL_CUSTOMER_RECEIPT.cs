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
   public  class DAL_CUSTOMER_RECEIPT:DB_Connect
    {
        public int ThemHoaDon(DTO_CUSTOMER_RECEIPT kv)
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
            cmd.CommandText = "INSERT [dbo].[CUSTOMER_RECEIPT] (RefID,RefDate,RefOrgNo,CurrencyID,CustomerID,CustomerName,Amount,CreatedBy,OwnerID,Description,Active) VALUES (N'" + kv.RefID+"',N'"+kv.RefDate + "',N'" + kv.RefOrgNo + "',N'" + kv.CurrencyID + "',N'" + kv.CustomerID + "',N'" + kv.CustomerName + "',N'" + kv.Amount + "',N'" + kv.CreatedBy + "',N'" + kv.OwnerID + "',N'" + kv.Description + "',"+active+")";
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
        public DataTable LayDanhSachHoaDon()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CUSTOMER_RECEIPT";
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
