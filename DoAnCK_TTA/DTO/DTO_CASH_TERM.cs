using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_CASH_TERM
    {
         public string  ID{get; set; }
         public string  Code{get; set; }
         public string  Name{get; set; }
         public string  NameEN{get; set; }
         public string  TypeID{get; set; }
         public string  DueTime{get; set; }
         public string  DiscountTime{get; set; }
         public string  DiscountPercent{get; set; }
         public string  DelayWithin{get; set; }
         public string  IsPublic{get; set; }
         public string  CreatedBy{get; set; }
         public string  CreatedDate{get; set; }
         public string  ModifiedBy{get; set; }
         public string  ModifiedDate{get; set; }
         public string  OwnerID{get; set; }
         public string  Description{get; set; }
         public string  Sorted{get; set; }
         public bool  Active{get; set; }
    }
}
