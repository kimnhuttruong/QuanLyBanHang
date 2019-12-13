using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_CUSTOMER_RECEIPT
    {
      public string ID{get;set;}
      public string RefID{get;set;}
      public string RefDate{get;set;}
      public string RefOrgNo{get;set;}
      public string RefType{get;set;}
      public string RefStatus{get;set;}
      public string PaymentMethod{get;set;}
      public string Barcode{get;set;}
      public string CurrencyID{get;set;}
      public string ExchangeRate{get;set;}
      public string BranchID{get;set;}
      public string ContractID{get;set;}
      public string CustomerID{get;set;}
      public string CustomerName{get;set;}
      public string CustomerAddress{get;set;}
      public string CustomerTax{get;set;}
      public string ContactName{get;set;}
      public string Amount{get;set;}
      public string FAmount{get;set;}
      public string Discount{get;set;}
      public string FDiscount{get;set;}
      public string Reconciled{get;set;}
      public string IsPublic{get;set;}
      public string CreatedBy{get;set;}
      public string CreatedDate{get;set;}
      public string ModifiedBy{get;set;}
      public string ModifiedDate{get;set;}
      public string OwnerID{get;set;}
      public string Description{get;set;}
      public string Sorted{get;set;}
      public bool Active{get;set;}
    }
}
