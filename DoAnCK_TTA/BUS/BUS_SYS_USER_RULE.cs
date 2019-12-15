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
    public class BUS_SYS_USER_RULE
    {
        public DataTable LayDanhSachPhanQuyen(string Group_ID)
        {
            DAL_SYS_USER_RULE dAL_SYS_USER_RULE = new DAL_SYS_USER_RULE();
            return dAL_SYS_USER_RULE.LayDanhSachPhanQuyen(Group_ID);

        }
        public DataTable LayDanhSachPhanQuyen()
        {
            DAL_SYS_USER_RULE dAL_SYS_USER_RULE = new DAL_SYS_USER_RULE();
            return dAL_SYS_USER_RULE.LayDanhSachPhanQuyen();

        }
        public DataTable LayDanhSachPhanQuyenButton(string mahinh)
        {
            DAL_SYS_USER_RULE dAL_SYS_USER_RULE = new DAL_SYS_USER_RULE();
            return dAL_SYS_USER_RULE.LayDanhSachPhanQuyenButton(mahinh);

        }
        public int ThemDanhSachPhanQuyen(DTO_SYS_USER_RULE u)
        {
            DAL_SYS_USER_RULE dAL_SYS_USER_RULE = new DAL_SYS_USER_RULE();
            return dAL_SYS_USER_RULE.ThemDanhSachPhanQuyen(u);

        }
    }
}
