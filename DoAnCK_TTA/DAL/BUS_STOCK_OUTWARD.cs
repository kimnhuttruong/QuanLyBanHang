using DoAnCK_TTA.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
    public class BUS_STOCK_OUTWARD
    {
        public int ThemPhieuXuatHang(DTO.DTO_STOCK_OUTWARD sTOCK_OUTWARD)
        {
            DAL.DAL_STOCK_OUTWARD dAL = new DAL_STOCK_OUTWARD();
            return dAL.ThemPhieuXuatHang(sTOCK_OUTWARD);

        }
    }
}
