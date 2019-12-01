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
    public class BUS_PRODUCT_GROUP
    {
        public int ThemNhomHang(DTO_PRODUCT_GROUP dTO_UNIT)
        {
            DAL_PRODUCT_GROUP dAL = new DAL_PRODUCT_GROUP();
            return dAL.ThemNhomHang(dTO_UNIT);

        }
        public int CapNhatNhomHang(DTO_PRODUCT_GROUP dTO_UNIT)
        {
            DAL_PRODUCT_GROUP dAL = new DAL_PRODUCT_GROUP();
            return dAL.CapNhatNhomHang(dTO_UNIT);

        }
        public int XoaNhomHang(string id)
        {
            DAL_PRODUCT_GROUP dAL = new DAL_PRODUCT_GROUP();
            return dAL.XoaNhomHang(id);

        }
        public DataTable LayThongTinNhomHang(string id)
        {
            DAL_PRODUCT_GROUP dAL = new DAL_PRODUCT_GROUP();
            return dAL.LayThongTinNhomHang(id);

        }
        public DataTable LayDanhSachNhomHang()
        {
            DAL_PRODUCT_GROUP dAL = new DAL_PRODUCT_GROUP();
            return dAL.LayDanhSachNhomHang();

        }
    }
}
