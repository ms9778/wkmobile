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
    
    public partial class Kompas_OrderDeliveries_SelectNew_Result
    {
        public System.Guid GUID { get; set; }
        public string OrderNo { get; set; }
        public double Trail { get; set; }
        public int DeliveryNo { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public double Weight { get; set; }
        public double Quantity { get; set; }
        public double CashOnDelivery { get; set; }
        public double Amount { get; set; }
        public byte Packedtype { get; set; }
        public byte DeliveryType { get; set; }
        public string Att { get; set; }
        public string Remarks { get; set; }
        public string RefNo { get; set; }
        public string RefOrderNo { get; set; }
        public string Weights { get; set; }
        public string Service { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public string WinEDITransporter { get; set; }
        public string WinEDIPackType { get; set; }
        public string WinEDIColliType { get; set; }
        public string TrackAndTrace { get; set; }
        public byte CSV2_Frankatur { get; set; }
        public byte CSV2_Forsendelsestype { get; set; }
        public byte CSV2_Forsikringstype { get; set; }
        public byte CSV2_1_4 { get; set; }
        public byte CSV2_1_2 { get; set; }
        public byte CSV2_1_1 { get; set; }
        public string ColliCodes { get; set; }
        public string GodsLines { get; set; }
        public string ShipName { get; set; }
        public string CompantName { get; set; }
        public string ClientNo { get; set; }
    }
}
