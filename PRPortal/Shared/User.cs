using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRPortal.Shared
{
    public class User
    {
        public int U_ID { get; set; }
        public string U_UserCode { get; set; }
        public string U_EmployeeName { get; set; }
        public string U_UserName { get; set; }
        public string U_Password { get; set; }
        public string U_EmailAddress { get; set; }
        public string U_Role { get; set; }
        public string U_ApprovalLevel { get; set; }
        public int U_Department { get; set; }
        public int U_CostCenter { get; set; }
        public int U_Approver1 { get; set; }
        public int U_Approver2 { get; set; }
        public int U_Approver3 { get; set; }
        public int U_Approver4 { get; set; }
        public int U_ApproverCode1 { get; set; }
        public int U_ApproverCode2 { get; set; }
        public int U_ApproverCode3 { get; set; }
        public int U_ApproverCode4 { get; set; }
    }
}
