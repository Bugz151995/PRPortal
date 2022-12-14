using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PRPortal.Shared
{
    public class PRLines
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public int? DocEntry { get; set; }
        public string? U_Dscription { get; set; } = string.Empty;
        public string? U_WhsCode { get; set; } = string.Empty;
        public string? U_ItemCode { get; set; } = string.Empty;
        public string? U_BinLoc { get; set; } = string.Empty;
        public string? U_Scope { get; set; } = string.Empty;
        public string? U_ScopeDesc { get; set; } = string.Empty;
        public string? U_MaterialCode { get; set; } = string.Empty;
        public string? U_MaterialDesc { get; set; } = string.Empty;
        public string? U_Quantity { get; set; } = string.Empty;
        public string? U_InfoPrice { get; set; } = string.Empty;
        public string? U_UomCode { get; set; } = string.Empty;
        public string? U_ItemSpecification { get; set; } = string.Empty;
        public string TaxCode { get; set; } = string.Empty;
        public string? U_OnHandQuantity { get; set; } = string.Empty;
        public string? U_InventoryType { get; set; } = string.Empty;
        public string? U_InventoryPurpose { get; set; } = string.Empty;

        public PRHeader? PHeader { get; set; }
    }
}
