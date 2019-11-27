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
    public class BUS_GROUP
    {
        public DataTable LayThongTinPhanQuyenbyName(string group )
        {
            DAL_GROUP dAL = new DAL_GROUP();
            return dAL.LayThongTinPhanQuyenbyName(group);

        }
        public DataTable LayThongTinPhanQuyenbyID(string group)
        {
            DAL_GROUP dAL = new DAL_GROUP();
            return dAL.LayThongTinPhanQuyenbyID(group);

        }
        public DataTable LayThongTinVaiTro()
        {
            DAL_GROUP dAL = new DAL_GROUP();
            return dAL.LayThongTinVaiTro();

        }
        public DataTable LayThongTinGroup()
        {
            DAL_GROUP dAL = new DAL_GROUP();
            return dAL.LayThongTinGroup();

        }
        public int ThemThongTinVaiTro(DTO_GROUP g)
        {
            DAL_GROUP dAL = new DAL_GROUP();
            return dAL.ThemThongTinVaiTro(g);

        }

    }
}
