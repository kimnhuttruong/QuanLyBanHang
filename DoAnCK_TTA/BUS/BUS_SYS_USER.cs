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
    public class BUS_SYS_USER
    {
        public bool CheckLogin(string username,string password)
        {
            DAL_SYS_USER dAL_SYS_USER_RULE = new DAL_SYS_USER();
            return dAL_SYS_USER_RULE.LayDanhSachPhanQuyen(username, password);

        }
        public DataTable LayThongTinPhanQuyen(string groupID)
        {
            DAL_SYS_USER dAL_SYS_USER_RULE = new DAL_SYS_USER();
            return dAL_SYS_USER_RULE.LayThongTinPhanQuyen(groupID);

        }
     
        public DataTable LayThongTinVaiTro()
        {
            DAL_SYS_USER dAL_SYS_USER_RULE = new DAL_SYS_USER();
            return dAL_SYS_USER_RULE.LayThongTinVaiTro();

        }
        public int ThemNguoiDung(DTO_SYS_USER u)
        {
            DAL_SYS_USER dAL_SYS_USER_RULE = new DAL_SYS_USER();
            return dAL_SYS_USER_RULE.ThemNguoiDung(u);

        }
        public int CapNhatNhom(string u)
        {
            DAL_SYS_USER dAL_SYS_USER_RULE = new DAL_SYS_USER();
            return dAL_SYS_USER_RULE.CapNhatNhom(u);

        }
    }
}
