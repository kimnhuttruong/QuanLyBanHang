using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCK_TTA.DAL;

namespace DoAnCK_TTA.BUS
{
    public class BUS_STOCK
    {
        public DataTable LayThongTinKhoHang()
        {
            DAL_STOCK dAL = new DAL_STOCK();
            return dAL.LayThongTinKhoHang();
        }
    }
}
