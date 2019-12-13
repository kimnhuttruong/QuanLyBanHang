using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_STOCK_TRANSFER_DETAIL
    {
      public string ID{get;set;}
      public string Transfer_ID{get;set;}
      public string RefType{get;set;}
      public string Product_ID{get;set;}
      public string Product_Name{get;set;}
      public string OutStock{get;set;}
      public string OutStockName{get;set;}
      public string InStock{get;set;}
      public string InStockName{get;set;}
      public string Unit{get;set;}
      public string UnitConvert{get;set;}
      public string UnitPrice{get;set;}
      public string Quantity{get;set;}
      public string Amount{get;set;}
      public string QtyConvert{get;set;}
      public string StoreID{get;set;}
      public string Batch{get;set;}
      public string Serial{get;set;}
      public string Description{get;set;}
      public string Sorted{get;set;}
    }
}
