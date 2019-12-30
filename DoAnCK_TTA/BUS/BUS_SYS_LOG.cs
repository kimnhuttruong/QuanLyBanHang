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
    public class BUS_SYS_LOG
    {
        public int ThemLichSu(DTO_SYS_LOG u)
        {
            DAL_SYS_LOG dAL_SYS_USER_RULE = new DAL_SYS_LOG();
            return dAL_SYS_USER_RULE.ThemLichSu(u);

        }
        public int XoaLichSu(string u)
        {
            DAL_SYS_LOG dAL_SYS_USER_RULE = new DAL_SYS_LOG();
            return dAL_SYS_USER_RULE.XoaLichSu(u);

        }
        public DataTable LayThongTinLog()
        {
            DAL_SYS_LOG dAL_SYS_USER_RULE = new DAL_SYS_LOG();
            return dAL_SYS_USER_RULE.LayThongTinLog();

        }
    }
}
