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
    
    public partial class TimeLine
    {
        public System.Guid GUID { get; set; }
        public System.Guid GUID_TimeHeaderLine { get; set; }
        public byte WeekDay { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> FromTime { get; set; }
        public Nullable<System.DateTime> ToTime { get; set; }
        public bool Posted { get; set; }
    }
}
