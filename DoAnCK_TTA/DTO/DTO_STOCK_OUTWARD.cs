using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_STOCK_OUTWARD
    {
      public string ID { get; set; }
      public string RefDate { get; set; }
      public string Ref_OrgNo { get; set; }
      public string RefType { get; set; }
      public string RefStatus { get; set; }
      public string PaymentMethod { get; set; }
      public string TermID { get; set; }
      public string PaymentDate { get; set; }
      public string DeliveryDate { get; set; }
      public string Barcode { get; set; }
      public string Department_ID { get; set; }
      public string Employee_ID { get; set; }
      public string Stock_ID { get; set; }
      public string Branch_ID { get; set; }
      public string Contract_ID { get; set; }
      public string Customer_ID { get; set; }
      public string CustomerName { get; set; }
      public string CustomerAddress { get; set; }
      public string Contact { get; set; }
      public string Reason { get; set; }
      public string Payment { get; set; }
      public string Currency_ID { get; set; }
      public string ExchangeRate { get; set; }
      public string Vat { get; set; }
      public string VatAmount { get; set; }
      public string Amount { get; set; }
      public string FAmount { get; set; }
      public string DiscountDate { get; set; }
      public string DiscountRate { get; set; }
      public string Discount { get; set; }
      public string OtherDiscount { get; set; }
      public string Charge { get; set; }
      public string Cost { get; set; }
      public string Profit { get; set; }
      public string User_ID { get; set; }
      public string IsClose { get; set; }
      public string Sorted { get; set; }
      public string Description { get; set; }
      public bool Active { get; set; }
    }
}
