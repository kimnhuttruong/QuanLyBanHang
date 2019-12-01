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
    public class BUS_CURRENCY
    {
        public int ThemTyGia(DTO_CURRENCY dTO_UNIT)
        {
            DAL_CURRENCY dAL = new DAL_CURRENCY();
            return dAL.ThemTyGia(dTO_UNIT);

        }
        public int CapNhatTyGia(DTO_CURRENCY dTO_UNIT)
        {
            DAL_CURRENCY dAL = new DAL_CURRENCY();
            return dAL.CapNhatTyGia(dTO_UNIT);

        }
        public int XoaTyGia(string id)
        {
            DAL_CURRENCY dAL = new DAL_CURRENCY();
            return dAL.XoaTyGia(id);

        }
        public DataTable LayThongTinTyGia(string id)
        {
            DAL_CURRENCY dAL = new DAL_CURRENCY();
            return dAL.LayThongTinTyGia(id);

        }
        public DataTable LayDanhSachTyGia()
        {
            DAL_CURRENCY dAL = new DAL_CURRENCY();
            return dAL.LayDanhSachTyGia();

        }
    }
}
