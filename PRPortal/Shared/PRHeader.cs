using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRPortal.Shared
{
    public class PRHeader
    {
        public int DocEntry { get; set; }
        public string U_ProjectID { get; set; } // revert back to int after testing
        public int U_ProjName { get; set; }
        public int U_Location { get; set; }
        public int U_PRType { get; set; } // no binded field
        public int U_DocNum { get; set; }
        public List<string> U_Department { get; set; } // Preferred Supplier to confirm if this is the field for it
        public List<string> U_Branch { get; set; } // no binded field // list
        public int U_DocStatus { get; set; }
        public DateTime? U_TaxDate { get; set; }
        public DateTime? U_ReqDate { get; set; }
        public int U_Urgency { get; set; }
        public int U_PreparedBy { get; set; }
        public int U_ReviewedBy { get; set; }

        public int U_ApprovedBy1 { get; set; }
        public int U_ApprovedBy2 { get; set; }
        public int U_ApprovedBy3 { get; set; }
        public int U_ApprovedBy4 { get; set; }
        public int U_ApprovedDate { get; set; }

        public int U_Remarks { get; set; }
        public int U_ApproverRemarks { get; set; }
    }
}
