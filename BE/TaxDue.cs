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
    
    public partial class TaxDue
    {
        public short ReturnInterval { get; set; }
        public Nullable<System.DateTime> ActiveStart { get; set; }
        public byte Months { get; set; }
        public byte DayInDueMonth { get; set; }
        public int RecordID { get; set; }
        public System.Guid GUID { get; set; }
    }
}
