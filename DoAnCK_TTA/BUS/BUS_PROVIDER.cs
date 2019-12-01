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
    public class BUS_PROVIDER
    {

        public int ThemNhaCungCap(DTO_PROVIDER dTO_Customer)
        {
            DAL_PROVIDER dAL = new DAL_PROVIDER();
            return dAL.ThemNhaCungCap(dTO_Customer);

        }
        public int CapNhatNhaCungCap(DTO_PROVIDER dTO_Customer)
        {
            DAL_PROVIDER dAL = new DAL_PROVIDER();
            return dAL.CapNhatNhaCungCap(dTO_Customer);

        }
        public int XoaNhaCungCap(string id)
        {
            DAL_PROVIDER dAL = new DAL_PROVIDER();
            return dAL.XoaNhaCungCap(id);

        }
        public DataTable LayThongTinNhaCungCap(string id)
        {
            DAL_PROVIDER dAL = new DAL_PROVIDER();
            return dAL.LayThongTinNhaCungCap(id);

        }
        public DataTable LayDanhSachNhaCungCap()
        {
            DAL_PROVIDER dAL = new DAL_PROVIDER();
            return dAL.LayDanhSachNhaCungCap();

        }
    }
}
