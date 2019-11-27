using DoAnCK_TTA.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
    public class BUS_EMPLOYEE
    {

        DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
        public DataTable LayThongTinNhanVien()
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.LayThongTinNhanVien();

        }
        public DataTable LayDanhSachQuanLy()
        {
            DAL_EMPLOYEE dAL = new DAL_EMPLOYEE();
            return dAL.LayDanhSachQuanLy();

        }
        public DataTable Detail(string id)
        {

            return dAL.Detail(id);

        }
        public int Delete(string id)
        {

            return dAL.Exec("DELETE FROM dbo.EMPLOYEE WHERE Employee_ID ='" + id + "'");
        }
        public DataTable getManger()
        {

            return dAL.GetData("SELECT Employee_Name,Employee_ID FROM dbo.EMPLOYEE");
        }

        public DataTable getDEPARTMENT()
        {
            return dAL.GetData("SELECT Department_ID,Department_Name FROM dbo.DEPARTMENT");
        }

        public int Insert(DTO.DTO_EMPLOYEE _EMPLOYEE)
        {

            return dAL.Insert(_EMPLOYEE);
        }

    }
}
