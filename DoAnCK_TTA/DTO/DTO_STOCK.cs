using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_STOCK
    {
        public string Stock_ID { get; set; }
        public string Stock_Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }

        public string Mobi { get; set; }
        public string Manager { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
