using DoAnCK_TTA.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
    public class BUS_CASH_TERM
    {
        public DataTable LayDanhCachDieuKhoan()
        {
            DAL_CASH_TERM dAL = new DAL_CASH_TERM();
            return dAL.LayDanhCachDieuKhoan();

        }
    }
}
