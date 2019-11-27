using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_PRODUCT
    {
        public string Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Unit { get; set; }
        public string Org_Price { get; set; } //gia mua
        public string Sale_Price { get; set; } // gia bán sỉ
        public string Retail_Price { get; set; } // giá bán le
        public string MinStock { get; set; } //tối thiểu
        public string Product_Group_ID { get; set; } // tính chất
        public string Provider_ID { get; set; } //Kho mặc định
        public bool Active { get; set; }
    }
}
