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
    
    public partial class Public_Delivery_Select_All_Result
    {
        public byte ADeliveryPacket { get; set; }
        public string ClientNo { get; set; }
        public short Days { get; set; }
        public string Delivery { get; set; }
        public string Description { get; set; }
        public System.Guid GUID { get; set; }
        public string PackFilePath { get; set; }
        public string PackFormat { get; set; }
        public int PackNextFileNo { get; set; }
        public int PackNextSerialNo { get; set; }
        public int PackNoAmount { get; set; }
        public string Remarks { get; set; }
        public short Tax { get; set; }
    }
}
