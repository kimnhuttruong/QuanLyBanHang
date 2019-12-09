using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCK_TTA.DAL;

namespace DoAnCK_TTA.BUS
{
    class BUS_DEPARTMENT
    {
        public int insert(DTO.DTO_DEPARTMENT f)
        {
            return new DAL.DAL_DEPARTMENT().insert(f);
        }
    }
}
