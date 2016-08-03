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
    
    public partial class Kompas_ProjectInvoiceCreateOrder_Result
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Agent { get; set; }
        public short Allocated { get; set; }
        public double Amount { get; set; }
        public double AmountBase { get; set; }
        public double ArchiveTrail { get; set; }
        public byte CalculationOfCargo { get; set; }
        public string CashDiscount { get; set; }
        public string Category { get; set; }
        public string ChangedBy { get; set; }
        public Nullable<System.DateTime> ChangedDate { get; set; }
        public string City { get; set; }
        public string CityName { get; set; }
        public string Contact { get; set; }
        public double CostAmount { get; set; }
        public double CostAmountBase { get; set; }
        public string CostCenter { get; set; }
        public string Country { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Currency { get; set; }
        public string Customer { get; set; }
        public string Delivery { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public int DeliveryWeek { get; set; }
        public string Department { get; set; }
        public Nullable<System.DateTime> Due { get; set; }
        public short EECCountry { get; set; }
        public byte EECTransCode { get; set; }
        public string EDILocationNr { get; set; }
        public string EMail { get; set; }
        public double EndDisc { get; set; }
        public double EndDiscBase { get; set; }
        public double EndDiscIncl { get; set; }
        public double EndDiscInclBase { get; set; }
        public double EndDiscPct { get; set; }
        public double Excise { get; set; }
        public double ExciseBase { get; set; }
        public string Giro { get; set; }
        public System.Guid GUID { get; set; }
        public string InternalRemarks { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public byte IsLiableToPayTax { get; set; }
        public bool KeepOrder { get; set; }
        public string Language { get; set; }
        public string LEANCustomersReference { get; set; }
        public string LEANOrderIdent { get; set; }
        public string LEANShipReference { get; set; }
        public bool LEANTest { get; set; }
        public short Link { get; set; }
        public string LockedBy { get; set; }
        public string Log { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> NumericOrderNo { get; set; }
        public short Optional1 { get; set; }
        public short Optional2 { get; set; }
        public short Optional3 { get; set; }
        public short Optional4 { get; set; }
        public short Optional5 { get; set; }
        public short Optional6 { get; set; }
        public short Optional7 { get; set; }
        public short Optional8 { get; set; }
        public double OptionalNumber1 { get; set; }
        public double OptionalNumber2 { get; set; }
        public double OptionalNumber3 { get; set; }
        public double OptionalNumber4 { get; set; }
        public double OptionalNumber5 { get; set; }
        public double OptionalNumber6 { get; set; }
        public double OptionalNumber7 { get; set; }
        public double OptionalNumber8 { get; set; }
        public string OptionalText1 { get; set; }
        public string OptionalText2 { get; set; }
        public string OptionalText3 { get; set; }
        public string OptionalText4 { get; set; }
        public string OptionalText5 { get; set; }
        public string OptionalText6 { get; set; }
        public string OptionalText7 { get; set; }
        public string OptionalText8 { get; set; }
        public string OrderCategory { get; set; }
        public string OrderCommunication { get; set; }
        public string OrderCommunicationStatus { get; set; }
        public string OrderCustomer { get; set; }
        public string OrderCustomerAddress1 { get; set; }
        public string OrderCustomerAddress2 { get; set; }
        public string OrderCustomerAddress3 { get; set; }
        public string OrderCustomerCity { get; set; }
        public string OrderCustomerCityName { get; set; }
        public string OrderCustomerContact { get; set; }
        public string OrderCustomerCountry { get; set; }
        public string OrderCustomerEMail { get; set; }
        public string OrderCustomerName { get; set; }
        public string OrderCustomerPostalCode { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public short OrderMerging { get; set; }
        public string OrderNo { get; set; }
        public string OrderText { get; set; }
        public short OrderType { get; set; }
        public string OurRef { get; set; }
        public string Payment { get; set; }
        public string PostalCode { get; set; }
        public string PriceList { get; set; }
        public string Project { get; set; }
        public string Purpose { get; set; }
        public int QuotationTrail { get; set; }
        public double Rate { get; set; }
        public int RecordID { get; set; }
        public string RecvNo { get; set; }
        public string Remarks { get; set; }
        public string Reports { get; set; }
        public double RoundedAmount { get; set; }
        public double RoundedAmountBase { get; set; }
        public string SalesRep { get; set; }
        public string SettleOrders { get; set; }
        public string Ship1 { get; set; }
        public string Ship2 { get; set; }
        public string Ship3 { get; set; }
        public string Ship4 { get; set; }
        public string Ship5 { get; set; }
        public string Ship6 { get; set; }
        public string Ship7 { get; set; }
        public string ShipCityName { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public string ShipEDILocationNr { get; set; }
        public string ShipEMail { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipTo { get; set; }
        public string Status { get; set; }
        public string SubDescription { get; set; }
        public Nullable<System.DateTime> SubEndDate { get; set; }
        public string SubIntervals { get; set; }
        public Nullable<System.DateTime> SubNextDate { get; set; }
        public string Tax { get; set; }
        public double TaxAmount { get; set; }
        public double TaxAmountBase { get; set; }
        public string TaxNo { get; set; }
        public double Total { get; set; }
        public double TotalBase { get; set; }
        public double TotalDuty { get; set; }
        public double TotalDutyBase { get; set; }
        public double TotalVolume { get; set; }
        public double TotalWeight { get; set; }
        public double Trail { get; set; }
        public double VatFee { get; set; }
        public double VatFeeBase { get; set; }
        public double VatFreeFee { get; set; }
        public double VatFreeFeeBase { get; set; }
        public double VATLiableAmount { get; set; }
        public double VATLiableAmountBase { get; set; }
        public string Voucher { get; set; }
        public string YourRef { get; set; }
        public double TotalUnrounded { get; set; }
        public double TotalUnroundedBase { get; set; }
    }
}
