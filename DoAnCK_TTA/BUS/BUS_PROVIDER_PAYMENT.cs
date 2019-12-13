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
   public  class BUS_PROVIDER_PAYMENT
    {
        public int ThemHoaDon(DTO_PROVIDER_PAYMENT dTO_PROVIDER)
        {
            DAL_PROVIDER_PAYMENT dAL = new DAL_PROVIDER_PAYMENT();
            return dAL.ThemHoaDon(dTO_PROVIDER);

        }
        public DataTable LayDanhSachHoaDon()
        {
            DAL_PROVIDER_PAYMENT dAL = new DAL_PROVIDER_PAYMENT();
            return dAL.LayDanhSachHoaDon();

        }
    }
}
