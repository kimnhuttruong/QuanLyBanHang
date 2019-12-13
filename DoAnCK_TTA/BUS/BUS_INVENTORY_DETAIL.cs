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
    public class BUS_INVENTORY_DETAIL
    {
        public DataTable LayDanhCachPhieuNhapHang()
        {
            DAL_INVENTORY_DETAIL dAL = new DAL_INVENTORY_DETAIL();
            return dAL.LayDanhCachPhieuNhapHang();

        }
        public int ThemPhieuNhapHang(DTO_INVENTORY_DETAIL dTO)
        {
            DAL_INVENTORY_DETAIL dAL = new DAL_INVENTORY_DETAIL();
            return dAL.ThemPhieuNhapHang(dTO);

        }
      
    }
}
