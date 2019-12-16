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
   public  class BUS_COMPANY
    {
        public int ThemCôngTy(DTO_COMPANY dTO_UNIT)
        {
            DAL_COMPANY dAL = new DAL_COMPANY();
            return dAL.ThemCongTy(dTO_UNIT);

        }
        public DataTable LayThongTinCongTy()
        {
            DAL_COMPANY dAL = new DAL_COMPANY();
            return dAL.LayDanhSachCongTy();

        }
    }
}
