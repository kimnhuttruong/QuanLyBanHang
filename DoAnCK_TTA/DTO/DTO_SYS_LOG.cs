using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_SYS_LOG
    {
        public string SYS_ID { get; set; }
        public string MChine { get; set; }
        public string IP { get; set; }
        public string UserID { get; set; }
        public string Created { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public string Action_Name { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

    }

}