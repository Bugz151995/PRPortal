using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRPortal.Shared
{
    public class PRLines
    {
        public int DocEntry { get; set; }
        public int U_ItemCode { get; set; }
        public int U_Dscription { get; set; }
        public int U_WhsCode { get; set; }
        public int U_BinLoc { get; set; }
        public int U_Scope { get; set; }
        public int U_ScopeDesc { get; set; }
        public int U_MaterialCode { get; set; }
        public int U_MaterialDesc { get; set; }
        public int U_Quantity { get; set; }
        public int U_InfoPrice { get; set; }
        public int U_UomCode { get; set; }
        public int U_ItemSpecification { get; set; }
        public int TaxCode { get; set; }
        public int U_OnHandQuantity { get; set; }
        public int U_InventoryType { get; set; }
        public int U_InventoryPurpose { get; set; }
    }
}
