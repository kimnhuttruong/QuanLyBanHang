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
    public class BUS_PRODUCT
    {
        public int ThemHangHoa(DTO_PRODUCT dTO_Customer)
        {
            DAL_PRODUCT dAL = new DAL_PRODUCT();
            return dAL.ThemHangHoa(dTO_Customer);

        }
        public int CapNhatHangHoa(DTO_PRODUCT dTO_Customer)
        {
            DAL_PRODUCT dAL = new DAL_PRODUCT();
            return dAL.CapNhatHangHoa(dTO_Customer);

        }
        public int XoaHangHoa(string id)
        {
            DAL_PRODUCT dAL = new DAL_PRODUCT();
            return dAL.XoaHangHoa(id);

        }
        public DataTable LayThongTinHangHoa(string id)
        {
            DAL_PRODUCT dAL = new DAL_PRODUCT();
            return dAL.LayThongTinHangHoa(id);

        }
        public DataTable LayDanhSachHangHoa()
        {
            DAL_PRODUCT dAL = new DAL_PRODUCT();
            return dAL.LayDanhSachHangHoa();

        }
    }
}
