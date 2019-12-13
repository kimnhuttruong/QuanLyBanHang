using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
   public class DTO_STOCK_TRANSFER
    {
      public string ID{get;set;}
      public string RefDate{get;set;}
      public string Ref_OrgNo{get;set;}
      public string RefType{get;set;}
      public string Department_ID{get;set;}
      public string Employee_ID{get;set;}
      public string FromStock_ID{get;set;}
      public string Sender_ID{get;set;}
      public string ToStock_ID{get;set;}
      public string Receiver_ID{get;set;}
      public string Branch_ID{get;set;}
      public string Contract_ID{get;set;}
      public string Currency_ID{get;set;}
      public string ExchangeRate{get;set;}
      public string Barcode{get;set;}
      public string Amount{get;set;}
      public string IsReview{get;set;}
      public string User_ID{get;set;}
      public string IsClose{get;set;}
      public string Sorted{get;set;}
      public string Description{get;set;}
      public string Active{get;set;}
    }
}
