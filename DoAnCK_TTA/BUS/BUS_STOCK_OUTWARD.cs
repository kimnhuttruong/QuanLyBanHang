using DoAnCK_TTA.DAL;
using DoAnCK_TTA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
    public class BUS_STOCK_OUTWARD
    {
        public int ThemPhieuXuatHang(DTO_STOCK_OUTWARD dTO_STOCK_OUTWARD_DETAIL)
        {
            DAL_STOCK_OUTWARD dAL = new DAL_STOCK_OUTWARD();
            return dAL.ThemPhieuXuatHang(dTO_STOCK_OUTWARD_DETAIL);

        }
        public DataTable LayThongTinBangKeChiTiet()
        {
            DAL_STOCK_OUTWARD dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD();
            return dAL_SYS_USER_RULE.LayThongTinBangKeChiTiet();

        }
        public DataTable LayThongTinBangKeChiTiet(string ma)
        {
            DAL_STOCK_OUTWARD dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD();
            return dAL_SYS_USER_RULE.LayThongTinBangKeChiTiet(ma);

        }
    }
}
