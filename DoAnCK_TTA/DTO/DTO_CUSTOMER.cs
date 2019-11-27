using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_CUSTOMER
    {
        public string Customer_ID { get; set; }
        public string OrderID { get; set; }
        public string CustomerName { get; set; }
        public string Customer_Type_ID { get; set; }
        public string Customer_Group_ID { get; set; }
        public string CustomerAddress { get; set; }
        public string Birthday { get; set; }
        public string Barcode { get; set; }
        public string Tax { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
        public string Contact { get; set; }
        public string Position { get; set; }
        public string NickYM { get; set; }
        public string NickSky { get; set; }
        public string Area { get; set; }
        public string District { get; set; }
        public string Contry { get; set; }
        public string City { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string CreditLimit { get; set; }
        public string Discount { get; set; }
        public string IsDebt { get; set; }
        public string IsDebtDetail { get; set; }
        public string IsProvider { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
