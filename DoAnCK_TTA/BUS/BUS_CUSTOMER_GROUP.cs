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
    public class BUS_CUSTOMER_GROUP
    {
        public int ThemKhuVuc(DTO_CUSTOMER_GROUP dTO_Customer)
        {
            DAL_CUSTOMER_GROUP dAL = new DAL_CUSTOMER_GROUP();
            return dAL.ThemKhuVuc(dTO_Customer);

        }
        public DataTable LayThongTinKhuVuc(string id)
        {
            DAL_CUSTOMER_GROUP dAL = new DAL_CUSTOMER_GROUP();
            return dAL.LayThongTinKhuVuc(id);

        }
        public DataTable LayDanhSachKhuVuc()
        {
            DAL_CUSTOMER_GROUP dAL = new DAL_CUSTOMER_GROUP();
            return dAL.LayDanhSachKhuVuc();

        }
    }
}
