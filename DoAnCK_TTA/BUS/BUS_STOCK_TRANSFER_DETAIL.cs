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
    class BUS_STOCK_TRANSFER_DETAIL
    {
        public DataTable LayThongTinBangKe()
        {
            DAL_STOCK_TRANSFER_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_TRANSFER_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinBangKeChiTiet();

        }
       
        public int ThemPhieuXuatHang(DTO_STOCK_TRANSFER_DETAIL a)
        {
            DAL_STOCK_TRANSFER_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_TRANSFER_DETAIL();
            return dAL_SYS_USER_RULE.ThemPhieuNhapHang(a);

        }
        //public int XoaPhieuXuatHang(string ma, string mahang, string Quantity)
        //{
        //    DAL_STOCK_TRANSFER_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_TRANSFER_DETAIL();
        //    return dAL_SYS_USER_RULE.XoaPhieuXuatHang(ma, mahang, Quantity);

        //}
    }
}
