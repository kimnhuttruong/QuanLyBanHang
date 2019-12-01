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
    public class BUS_UNIT
    {
        public int ThemDonViTinh(DTO_UNIT dTO_UNIT)
        {
            DAL_UNIT dAL = new DAL_UNIT();
            return dAL.ThemDonViTinh(dTO_UNIT);

        }
        public int CapNhatDonViTinh(DTO_UNIT dTO_UNIT)
        {
            DAL_UNIT dAL = new DAL_UNIT();
            return dAL.CapNhatDonViTinh(dTO_UNIT);

        }
        public int XoaDonViTinh(string id)
        {
            DAL_UNIT dAL = new DAL_UNIT();
            return dAL.XoaDonViTinh(id);

        }
        public DataTable LayThongTinDonViTinh(string id)
        {
            DAL_UNIT dAL = new DAL_UNIT();
            return dAL.LayThongTinDonViTinh(id);

        }
        public DataTable LayDanhSachDonViTinh()
        {
            DAL_UNIT dAL = new DAL_UNIT();
            return dAL.LayDanhSachDonViTinh();

        }
    }
}
