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
    
    public partial class Public_Orders2_Select_All_Result
    {
        public System.Guid GUID { get; set; }
        public System.Guid LinkGUID { get; set; }
        public string OrderNo { get; set; }
        public bool WPA_Activated { get; set; }
        public Nullable<System.DateTime> WPA_EndDate { get; set; }
        public Nullable<System.DateTime> WPA_LastSend { get; set; }
        public short WPA_LastStatus { get; set; }
        public byte WPA_Prioritet { get; set; }
        public Nullable<System.DateTime> WPA_StartDate { get; set; }
        public short WPA_Status { get; set; }
        public bool WPA_Type { get; set; }
        public string WPA_Description { get; set; }
        public string WPA_CRMInfo1 { get; set; }
        public string WPA_CRMInfo2 { get; set; }
    }
}
