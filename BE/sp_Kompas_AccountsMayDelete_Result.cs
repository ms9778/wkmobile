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
    
    public partial class sp_Kompas_AccountsMayDelete_Result
    {
        public int MayDelete { get; set; }
        public Nullable<bool> HasTransactions { get; set; }
        public Nullable<bool> HasTransEntry { get; set; }
        public Nullable<bool> IsSystemAccount { get; set; }
        public Nullable<bool> IsCustomerGroupAccount { get; set; }
        public Nullable<bool> IsSupplierGroupAccount { get; set; }
        public Nullable<bool> IsInventoryGroupAccount { get; set; }
    }
}
