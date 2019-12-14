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
    public class BUS_EMPLOYEE
    {

        public int ThemNhanVien(DTO_EMPLOYEE dTO_EMPLOYEE)
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.ThemNhanVien(dTO_EMPLOYEE);

        }
        public int CapNhatNhanVien(DTO_EMPLOYEE dTO_EMPLOYEE)
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.CapNhatNhanVien(dTO_EMPLOYEE);

        }
        public int XoaNhanVien(string id)
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.XoaNhanVien(id);

        }
        public DataTable LayThongTinNhanVien(string id)
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.LayThongTinNhanVien(id);

        }
        public DataTable LayDanhSachNhanVien()
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.LayDanhSachNhanVien();

        }
        public DataTable BaoCaoDoanhSoNhanVien()
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.BaoCaoDoanhSoNhanVien();

        }
        public DataTable BaoCaoDoanhSoNhanVienChiTiet()
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.BaoCaoDoanhSoNhanVienChiTiet();

        }
    }
}
