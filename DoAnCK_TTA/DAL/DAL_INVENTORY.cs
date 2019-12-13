using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DAL
{
   public  class DAL_INVENTORY:DB_Connect
    {
        public DataTable LayDanhSachTonKho()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select input.Product_ID,p.Product_Name,input.Stock_ID,input.Unit,s.Stock_Name,sum(cast(input.Quantity as float)) as Nhap,sum(cast(input.Amount as float)) as SoTienNhap,(sum(cast(IsNULL(output.Quantity,0) as float))) as Xuat,sum(cast(IsNULL(output.Amount,0) as float)) as SoTienXuat  from STOCK_INWARD_DETAIL input left join STOCK_outWARD_DETAIL output on input.Product_ID = output.Product_ID and input.Stock_ID = output.Stock_ID,STOCK s, PRODUCT p   where s.Stock_ID = input.Stock_ID and p.Product_ID = input.Product_ID  group by  input.Product_ID,input.Stock_ID,input.Unit,s.Stock_Name,p.Product_Name ";
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
