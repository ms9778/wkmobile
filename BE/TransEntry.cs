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
    
    public partial class TransEntry
    {
        public string Journal { get; set; }
        public string Account { get; set; }
        public string Customer { get; set; }
        public string Supplier { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Source { get; set; }
        public string Voucher { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public double Rate { get; set; }
        public double Quantity { get; set; }
        public Nullable<System.DateTime> Due { get; set; }
        public string Tax { get; set; }
        public double TaxAmount { get; set; }
        public string Department { get; set; }
        public string CostCenter { get; set; }
        public string Purpose { get; set; }
        public string Project { get; set; }
        public string Employee { get; set; }
        public string SetOff { get; set; }
        public string Remarks { get; set; }
        public short Error { get; set; }
        public int RecordId { get; set; }
        public double AmountBase { get; set; }
        public short Opening { get; set; }
        public short LineNo { get; set; }
        public string InvoiceNo { get; set; }
        public string BetalingsID { get; set; }
        public string KortArt { get; set; }
        public byte Code { get; set; }
        public string PeriodID { get; set; }
        public double CashDiscountAmount { get; set; }
        public string Optional1 { get; set; }
        public string Optional2 { get; set; }
        public System.Guid GUID { get; set; }
        public string DocumentPath { get; set; }
    }
}
