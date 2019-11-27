using DoAnCK_TTA.DAL;
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
        public DataTable LayThongTinNhanVien()
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.LayThongTinNhanVien();

        }
    }
}
