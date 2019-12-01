using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCK_TTA.DAL;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.BUS
{
    public class BUS_STOCK
    {
        public int ThemKhoHang(DTO_STOCK dTO_STOCK)
        {
            DAL_STOCK dAL = new DAL_STOCK();
            return dAL.ThemKhoHang(dTO_STOCK);

        }
        public int CapNhatKhoHang(DTO_STOCK dTO_STOCK)
        {
            DAL_STOCK dAL = new DAL_STOCK();
            return dAL.CapNhatKhoHang(dTO_STOCK);

        }
        public int XoaKhoHang(string id)
        {
            DAL_STOCK dAL = new DAL_STOCK();
            return dAL.XoaKhoHang(id);

        }
        public DataTable LayThongTinKhoHang(string id)
        {
            DAL_STOCK dAL = new DAL_STOCK();
            return dAL.LayThongTinKhoHang(id);

        }
        public DataTable LayThongTinKhoHang()
        {
            DAL_STOCK dAL = new DAL_STOCK();
            return dAL.LayThongTinKhoHang();

        }
       
    }
}
