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
    public class BUS_STOCK_OUTWARD_DETAIL
    {
        public DataTable LayThongTinBangKe()
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinBangKe();

        }
        public DataTable LayThongTinCongNoChiTiet()
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinCongNoChiTiet();

        }
        public DataTable LayThongTinThanhToanNgayChiTiet()
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinThanhToanNgayChiTiet();

        }
        public DataTable LayThongTinBangKeChiTiet(string ma)
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinBangKeChiTiet(ma);

        }
        public DataTable LayThongTinBangKeChiTietDataTable(string ma)
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinBangKeChiTietDataTable(ma);

        }
        public int ThemPhieuXuatHang(DTO_STOCK_OUTWARD_DETAIL a)
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.ThemPhieuXuatHang(a);

        }
        public int XoaPhieuXuatHang(string ma)
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.XoaPhieuXuatHang(ma);

        }
        public DataTable LayThongTinMuaHangTheoKH()
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinMuaHangTheoKH();

        }
        public DataTable LayThongTinLoiNhuan()
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinLoiNhuan();

        }
        public DataTable LayThongTinLoiNhuanTheoHangHoa()
        {
            DAL_STOCK_OUTWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_OUTWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinLoiNhuanTheoHangHoa();

        }


    }
}
