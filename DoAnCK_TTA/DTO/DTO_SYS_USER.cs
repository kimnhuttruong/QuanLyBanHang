using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_SYS_USER
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Group_ID { get; set; }
        public string Group_Name { get; set; }
        public string Description { get; set; }
        public string PartID { get; set; }
        
        public string Employee_ID { get; set; }
        public bool Active { get; set; }
    }
}
