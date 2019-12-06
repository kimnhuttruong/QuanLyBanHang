using DoAnCK_TTA.DAL;
using DoAnCK_TTA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
    class BUS_STOCK_INWARD
    {
        public int ThemPhieuNhapHang(DTO_STOCK_INWARD dTO_STOCK_INWARD_DETAIL)
        {
            DAL_STOCK_INWARD dAL = new DAL_STOCK_INWARD();
            return dAL.ThemPhieuNhapHang(dTO_STOCK_INWARD_DETAIL);

        }
    }
}
