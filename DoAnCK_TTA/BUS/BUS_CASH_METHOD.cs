using DoAnCK_TTA.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
    public class BUS_CASH_METHOD
    {
        public DataTable LayDanhCachThanhToan()
        {
            DAL_CASH_METHOD dAL = new DAL_CASH_METHOD();
            return dAL.LayDanhCachThanhToan();

        }
    }
}
