//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BE
{
    using System;
    using System.Collections.Generic;
    
    public partial class vPurDiscount
    {
        public int RecordID { get; set; }
        public string Supplier { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCat { get; set; }
        public string SupplierCatName { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public string InventoryCat { get; set; }
        public string InventoryCatName { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Percent { get; set; }
        public Nullable<System.DateTime> Active { get; set; }
        public Nullable<System.DateTime> InActive { get; set; }
        public string ExternalNo { get; set; }
        public string Remarks { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public System.Guid GUID { get; set; }
    }
}
