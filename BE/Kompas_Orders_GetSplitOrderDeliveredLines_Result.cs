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
    
    public partial class Kompas_Orders_GetSplitOrderDeliveredLines_Result
    {
        public string OrderNo { get; set; }
        public string Item { get; set; }
        public string Account { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public Nullable<double> MaxDeliver { get; set; }
        public int RecordID { get; set; }
        public double Price { get; set; }
        public int SplitQuantity { get; set; }
        public int ErrorQuantity { get; set; }
        public int HasSerialNo { get; set; }
        public string Unit { get; set; }
        public double Conversion { get; set; }
        public Nullable<System.DateTime> Delivery { get; set; }
    }
}
