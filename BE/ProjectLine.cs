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
    
    public partial class ProjectLine
    {
        public decimal RecordID { get; set; }
        public string Project { get; set; }
        public string OrderNo { get; set; }
        public string Employee { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Item { get; set; }
        public double UsedTime { get; set; }
        public Nullable<double> Quantity { get; set; }
        public double CostPrice { get; set; }
        public double SalesPrice { get; set; }
        public string Department { get; set; }
        public string CostCenter { get; set; }
        public string PurPose { get; set; }
        public string Remarks { get; set; }
        public bool Invoiced { get; set; }
        public Nullable<bool> InvoiceAble { get; set; }
        public string Status { get; set; }
        public string Source { get; set; }
        public double Trail { get; set; }
        public byte Code { get; set; }
        public int LinkRecordID { get; set; }
        public string Optional1 { get; set; }
        public string Optional2 { get; set; }
        public string Account { get; set; }
        public string Description { get; set; }
        public string Voucher { get; set; }
        public string InvoiceNo { get; set; }
        public string AcontoOrderNo { get; set; }
        public System.Guid GUID { get; set; }
        public double LastesActivatingTrail { get; set; }
        public double DeActivatingTrail { get; set; }
        public string BatchNo { get; set; }
        public string ChangedBy { get; set; }
        public Nullable<System.DateTime> ChangedDate { get; set; }
        public string PurchaseNo { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public double Discount { get; set; }
        public double OrgSalesPrice { get; set; }
    }
}
