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
    
    public partial class Kompas_CustomerInterest_GetEntries_Result
    {
        public bool Select { get; set; }
        public string Customer { get; set; }
        public string Name { get; set; }
        public string Grouping { get; set; }
        public string Interest { get; set; }
        public Nullable<System.DateTime> LastInterest { get; set; }
        public double Balance { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public Nullable<double> DueAmount { get; set; }
        public Nullable<double> DueInterest { get; set; }
        public Nullable<double> DueInterestCharge { get; set; }
        public Nullable<double> DueReminder { get; set; }
        public double CarrierBalance { get; set; }
        public double Rate { get; set; }
        public double CalculatedInterest { get; set; }
        public double Charge { get; set; }
    }
}
