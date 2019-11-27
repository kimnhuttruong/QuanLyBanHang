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
        public DataTable LayThongTinHangHoa()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Product_ID,Product_Name,Unit,Org_Price,Sale_Price,Retail_Price,MinStock,Product_Group_ID,Provider_ID,Active from Product";
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
