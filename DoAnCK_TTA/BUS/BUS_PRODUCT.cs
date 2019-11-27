using DoAnCK_TTA.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
    public class BUS_PRODUCT
    {
        public DataTable LayThongTinHangHoa()
        {
            DAL_PRODUCT dAL = new DAL_PRODUCT();
            return dAL.LayThongTinHangHoa();
        }
    }
}
