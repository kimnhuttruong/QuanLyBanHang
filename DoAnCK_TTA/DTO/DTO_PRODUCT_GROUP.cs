using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_PRODUCT_GROUP
    {
        public string ProductGroup_ID { get; set; }
        public string ProductGroup_Name { get; set; }
        public string Description { get; set; }
        public bool IsMain { get; set; }
        public bool Active { get; set; }
    }
}
