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
    public class BUS_DEPARTMENT
    {
        public int ThemBoPhan(DTO_DEPARTMENT dTO_DEPARTMENT)
        {
            DAL_DEPARTMENT dAL = new DAL_DEPARTMENT();
            return dAL.ThemBoPhan(dTO_DEPARTMENT);

        }
        public int CapNhatBoPhan(DTO_DEPARTMENT dTO_DEPARTMENT)
        {
            DAL_DEPARTMENT dAL = new DAL_DEPARTMENT();
            return dAL.CapNhatBoPhan(dTO_DEPARTMENT);

        }
        public int XoaBoPhan(string id)
        {
            DAL_DEPARTMENT dAL = new DAL_DEPARTMENT();
            return dAL.XoaBoPhan(id);

        }
        public DataTable LayThongTinBoPhan(string id)
        {
            DAL_DEPARTMENT dAL = new DAL_DEPARTMENT();
            return dAL.LayThongTinBoPhan(id);

        }
        public DataTable LayDanhSachBoPhan()
        {
            DAL_DEPARTMENT dAL = new DAL_DEPARTMENT();
            return dAL.LayDanhSachBoPhan();

        }
    }
}
