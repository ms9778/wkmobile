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
    
    public partial class Journal
    {
        public string Journal1 { get; set; }
        public short JournalType { get; set; }
        public short Module { get; set; }
        public string Source { get; set; }
        public short Recurring { get; set; }
        public short Remove { get; set; }
        public double Balance { get; set; }
        public string Name1 { get; set; }
        public string Account1 { get; set; }
        public double Balance1 { get; set; }
        public string Letter1 { get; set; }
        public string Name2 { get; set; }
        public string Account2 { get; set; }
        public double Balance2 { get; set; }
        public string Letter2 { get; set; }
        public string Name3 { get; set; }
        public string Account3 { get; set; }
        public double Balance3 { get; set; }
        public string Letter3 { get; set; }
        public string Name4 { get; set; }
        public string Account4 { get; set; }
        public double Balance4 { get; set; }
        public string Letter4 { get; set; }
        public string Name5 { get; set; }
        public string Account5 { get; set; }
        public double Balance5 { get; set; }
        public string Letter5 { get; set; }
        public string LockedBy { get; set; }
        public Nullable<System.DateTime> LastPosted { get; set; }
        public short Printed { get; set; }
        public string Remarks { get; set; }
        public short NewVoucherNo { get; set; }
        public short DefaultCode { get; set; }
        public bool DuplicateFields { get; set; }
        public bool GenerateAmount { get; set; }
        public bool MultiCurrency { get; set; }
        public System.Guid GUID { get; set; }
        public int JournalNo { get; set; }
        public double TotalDebit { get; set; }
        public double TotalCredit { get; set; }
    }
}
