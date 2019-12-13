using DoAnCK_TTA.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
    public class BUS_INVENTORY
    {
        public DataTable LayDanhCachPhieuNhapHang()
        {
            DAL_INVENTORY dAL = new DAL_INVENTORY();
            return dAL.LayDanhSachTonKho();

        }
    }
}
