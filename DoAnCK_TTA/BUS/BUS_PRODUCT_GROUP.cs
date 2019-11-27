using DoAnCK_TTA.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
    public class BUS_PRODUCT_GROUP
    {
        public DataTable LayThongTinNhomHang()
        {
            DAL_PRODUCT_GROUP dAL = new DAL_PRODUCT_GROUP();
            return dAL.LayThongTinNhomHang();
        }
    }
}
