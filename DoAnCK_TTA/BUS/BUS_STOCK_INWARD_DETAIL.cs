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
   public  class BUS_STOCK_INWARD_DETAIL
    {
        public DataTable LayThongTinBangKe()
        {
            DAL_STOCK_INWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_INWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinBangKe();

        }
        public DataTable LayThongTinBangKeCongNo()
        {
            DAL_STOCK_INWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_INWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinBangKeCongNo();

        }
        public DataTable LayThongTinBangKeThanhToanNgay()
        {
            DAL_STOCK_INWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_INWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinBangKeThanhToanNgay();

        }
        public DataTable LayThongTinBangKeChiTiet(string ma)
        {
            DAL_STOCK_INWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_INWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinBangKeChiTiet(ma);

        }
        public DataTable LayThongTinBangKeChiTietDataTable(string ma)
        {
            DAL_STOCK_INWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_INWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinBangKeChiTietDataTable(ma);

        }
        public int ThemPhieuNhapHang(DTO_STOCK_INWARD_DETAIL a )
        {
            DAL_STOCK_INWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_INWARD_DETAIL();
            return dAL_SYS_USER_RULE.ThemPhieuNhapHang(a);

        }
        public int XoaPhieuNhapHang(string ma,string mahang,string Quantity)
        {
            DAL_STOCK_INWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_INWARD_DETAIL();
            return dAL_SYS_USER_RULE.XoaPhieuNhapHang(ma,mahang, Quantity);

        }
        public DataTable LayThongTinMuaHangTheoNgay()
        {
            DAL_STOCK_INWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_INWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinMuaHangTheoNgay();


        }
        public DataTable LayThongTinMuaHangTheoNCC()
        {
            DAL_STOCK_INWARD_DETAIL dAL_SYS_USER_RULE = new DAL_STOCK_INWARD_DETAIL();
            return dAL_SYS_USER_RULE.LayThongTinMuaHangTheoNCC();


        }

    }
}
