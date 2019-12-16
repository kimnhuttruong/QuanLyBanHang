using DoAnCK_TTA.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.BUS
{
   public  class BUS_SYS
    {
        public string SaoLuu(string u)
        {
          
            {
                DAL_SYS dAL = new DAL_SYS();
                return dAL.SaoLuu(u);
            }
         
        }
        public string PhucHoi(string u)
        {

            {
                DAL_SYS dAL = new DAL_SYS();
                return dAL.PhucHoi(u);
            }

        }
    }
}
