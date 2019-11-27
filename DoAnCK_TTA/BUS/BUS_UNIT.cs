using DoAnCK_TTA.DAL;
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
        public DataTable LayThongTinDonVi()
        {
            DAL_UNIT dAL = new DAL_UNIT();
            return dAL.LayThongTinDonVI();
        }
    }
}
