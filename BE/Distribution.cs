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
    
    public partial class Distribution
    {
        public int RecordID { get; set; }
        public string Account { get; set; }
        public string Department { get; set; }
        public string CostCenter { get; set; }
        public string Purpose { get; set; }
        public string Project { get; set; }
        public string ToAccount { get; set; }
        public string ToDepartment { get; set; }
        public string ToCostCenter { get; set; }
        public string ToPurpose { get; set; }
        public string ToProject { get; set; }
        public double Percent { get; set; }
        public double Amount { get; set; }
        public string Remarks { get; set; }
        public short DistributeOn { get; set; }
        public System.Guid GUID { get; set; }
    }
}
