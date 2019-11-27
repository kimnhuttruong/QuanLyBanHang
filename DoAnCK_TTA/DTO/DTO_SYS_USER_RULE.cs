using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_SYS_USER_RULE
    {
        public string Goup_ID { get; set; }
        public string Object_ID { get; set; }
        public string Rule_ID { get; set; }
        public int AllowAdd { get; set; }
        public int AllowDelete { get; set; }
        public int AllowEdit { get; set; }
        public int AllowAccess { get; set; }
        public int AllowPrint { get; set; }
        public int AllowExport { get; set; }
        public int AllowImport { get; set; }
        public int Active { get; set; }
    }
}
