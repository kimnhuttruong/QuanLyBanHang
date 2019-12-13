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
    public class BUS_CUSTOMER_RECEIPT
    {
        public int ThemHoaDon(DTO_CUSTOMER_RECEIPT dTO_Customer)
        {
            DAL_CUSTOMER_RECEIPT dAL = new DAL_CUSTOMER_RECEIPT();
            return dAL.ThemHoaDon(dTO_Customer);

        }
        public DataTable LayDanhSachHoaDon()
        {
            DAL_CUSTOMER_RECEIPT dAL = new DAL_CUSTOMER_RECEIPT();
            return dAL.LayDanhSachHoaDon();

        }
    }
}
