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
    public class BUS_CUSTOMER
    {
        public int ThemKhachHang(DTO_CUSTOMER dTO_Customer)
        {
            DAL_CUSTOMER dAL = new DAL_CUSTOMER();
            return dAL.ThemKhachHang(dTO_Customer);

        }
        public int CapNhatKhachHang(DTO_CUSTOMER dTO_Customer)
        {
            DAL_CUSTOMER dAL = new DAL_CUSTOMER();
            return dAL.CapNhatKhachHang(dTO_Customer);

        }
        public int XoaKhachHang(string id)
        {
            DAL_CUSTOMER dAL = new DAL_CUSTOMER();
            return dAL.XoaKhachHang(id);

        }
        public DataTable LayThongTinKhachHang(string id)
        {
            DAL_CUSTOMER dAL = new DAL_CUSTOMER();
            return dAL.LayThongTinKhachHang(id);

        }
        public DataTable LayDanhSachKhachHang()
        {
            DAL_CUSTOMER dAL = new DAL_CUSTOMER();
            return dAL.LayDanhSachKhachHang();

        }
    }
}
