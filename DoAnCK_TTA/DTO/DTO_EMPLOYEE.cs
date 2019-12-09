using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DTO
{
    public class DTO_EMPLOYEE
    {
        public string ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Group_ID { get; set; }
        public string Group_Name { get; set; }
        public string Description { get; set; }
        public string PartID { get; set; }
        public bool Active { get; set; }

        public string Employee_ID1 { get => Employee_ID; set => Employee_ID = value; }
        public string Employee_Name1 { get => Employee_Name; set => Employee_Name = value; }
        public string Department_ID1 { get => Department_ID; set => Department_ID = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Mobile1 { get => Mobile; set => Mobile = value; }
        public string Fax1 { get => Fax; set => Fax = value; }
        public string Department_Name1 { get => Department_Name; set => Department_Name = value; }
        public string Manager_ID1 { get => Manager_ID; set => Manager_ID = value; }

        string Employee_ID;
        string Employee_Name;
        string Department_ID;
        string Address;
        string Mobile;
        string Fax;
        string Department_Name;
        string Manager_ID;





    }
}
