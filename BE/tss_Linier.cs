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
    
    public partial class tss_Linier
    {
        public decimal LinieID { get; set; }
        public string Item { get; set; }
        public Nullable<float> Antal { get; set; }
        public string Notat { get; set; }
        public string Project { get; set; }
        public string Employee { get; set; }
        public Nullable<System.DateTime> Dato { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DatoStart { get; set; }
        public Nullable<System.DateTime> DatoSlut { get; set; }
        public Nullable<bool> Faktureret { get; set; }
        public Nullable<bool> Fakturerbar { get; set; }
    }
}
