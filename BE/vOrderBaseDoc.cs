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
    
    public partial class vOrderBaseDoc
    {
        public string Orders_OrderNo { get; set; }
        public string Orders_Customer { get; set; }
        public string Orders_Name { get; set; }
        public string Orders_Address1 { get; set; }
        public string Orders_Address2 { get; set; }
        public string Orders_Address3 { get; set; }
        public string Orders_City { get; set; }
        public string Orders_Country { get; set; }
        public string Orders_Contact { get; set; }
        public string Orders_EMail { get; set; }
        public string Orders_ShipTo { get; set; }
        public string Orders_Ship1 { get; set; }
        public string Orders_Ship2 { get; set; }
        public string Orders_Ship3 { get; set; }
        public string Orders_Ship4 { get; set; }
        public string Orders_Ship5 { get; set; }
        public string Orders_Ship6 { get; set; }
        public string Orders_Ship7 { get; set; }
        public string Orders_ShipEMail { get; set; }
        public string Orders_PriceList { get; set; }
        public string Orders_Category { get; set; }
        public string Orders_SalesRep { get; set; }
        public string Orders_Payment { get; set; }
        public string Orders_Giro { get; set; }
        public string Orders_Tax { get; set; }
        public string Orders_TaxNo { get; set; }
        public string Orders_Agent { get; set; }
        public string Orders_Delivery { get; set; }
        public string Orders_Currency { get; set; }
        public double Orders_Rate { get; set; }
        public string Orders_Language { get; set; }
        public string Orders_Department { get; set; }
        public string Orders_CostCenter { get; set; }
        public string Orders_Purpose { get; set; }
        public string Orders_Project { get; set; }
        public string Orders_Status { get; set; }
        public short Orders_Allocated { get; set; }
        public double Orders_Amount { get; set; }
        public double Orders_AmountBase { get; set; }
        public double Orders_TaxAmount { get; set; }
        public double Orders_TaxAmountBase { get; set; }
        public double Orders_Total { get; set; }
        public double Orders_TotalBase { get; set; }
        public string Orders_Remarks { get; set; }
        public string Orders_Log { get; set; }
        public double Orders_Trail { get; set; }
        public Nullable<System.DateTime> Orders_Due { get; set; }
        public string Orders_Voucher { get; set; }
        public short Orders_Link { get; set; }
        public double Orders_RoundedAmount { get; set; }
        public double Orders_RoundedAmountBase { get; set; }
        public double Orders_VatFee { get; set; }
        public double Orders_VatFeeBase { get; set; }
        public double Orders_VatFreeFee { get; set; }
        public double Orders_VatFreeFeeBase { get; set; }
        public double Orders_Excise { get; set; }
        public double Orders_ExciseBase { get; set; }
        public double Orders_EndDisc { get; set; }
        public double Orders_EndDiscBase { get; set; }
        public double Orders_EndDiscPct { get; set; }
        public string Orders_CreatedBy { get; set; }
        public Nullable<System.DateTime> Orders_CreatedDate { get; set; }
        public string Orders_ChangedBy { get; set; }
        public Nullable<System.DateTime> Orders_ChangedDate { get; set; }
        public int Orders_RecordID { get; set; }
        public Nullable<System.DateTime> Orders_InvoiceDate { get; set; }
        public Nullable<System.DateTime> Orders_DeliveryDate { get; set; }
        public string Orders_RecvNo { get; set; }
        public string Orders_Reports { get; set; }
        public double Orders_TotalWeight { get; set; }
        public double Orders_TotalVolume { get; set; }
        public double Orders_TotalDuty { get; set; }
        public double Orders_TotalDutyBase { get; set; }
        public string Orders_OrderText { get; set; }
        public double Orders_CostAmount { get; set; }
        public double Orders_CostAmountBase { get; set; }
        public short Orders_OrderType { get; set; }
        public string Orders_SubIntervals { get; set; }
        public Nullable<System.DateTime> Orders_SubNextDate { get; set; }
        public Nullable<System.DateTime> Orders_SubEndDate { get; set; }
        public Nullable<System.DateTime> Orders_OrderDate { get; set; }
        public int Orders_DeliveryWeek { get; set; }
        public string Orders_OptionalText1 { get; set; }
        public string Orders_OptionalText2 { get; set; }
        public string Orders_OptionalText3 { get; set; }
        public string Orders_OptionalText4 { get; set; }
        public string Orders_OptionalText5 { get; set; }
        public string Orders_OptionalText6 { get; set; }
        public string Orders_OptionalText7 { get; set; }
        public string Orders_OptionalText8 { get; set; }
        public double Orders_OptionalNumber1 { get; set; }
        public double Orders_OptionalNumber2 { get; set; }
        public double Orders_OptionalNumber3 { get; set; }
        public double Orders_OptionalNumber4 { get; set; }
        public double Orders_OptionalNumber5 { get; set; }
        public double Orders_OptionalNumber6 { get; set; }
        public double Orders_OptionalNumber7 { get; set; }
        public double Orders_OptionalNumber8 { get; set; }
        public short Orders_Optional1 { get; set; }
        public short Orders_Optional2 { get; set; }
        public short Orders_Optional3 { get; set; }
        public short Orders_Optional4 { get; set; }
        public short Orders_Optional5 { get; set; }
        public short Orders_Optional6 { get; set; }
        public short Orders_Optional7 { get; set; }
        public short Orders_Optional8 { get; set; }
        public string Orders_OrderCustomer { get; set; }
        public string Orders_OrderCustomerName { get; set; }
        public string Orders_OrderCustomerAddress1 { get; set; }
        public string Orders_OrderCustomerAddress2 { get; set; }
        public string Orders_OrderCustomerAddress3 { get; set; }
        public string Orders_OrderCustomerCity { get; set; }
        public string Orders_OrderCustomerCountry { get; set; }
        public string Orders_OrderCustomerContact { get; set; }
        public string Orders_OrderCustomerEMail { get; set; }
        public string Orders_CashDiscount { get; set; }
        public string Orders_YourRef { get; set; }
        public string Orders_OurRef { get; set; }
        public short Orders_EECCountry { get; set; }
        public byte Orders_EECTransCode { get; set; }
        public string Orders_SettleOrders { get; set; }
        public string Orders_SubDescription { get; set; }
        public string Lines_Item { get; set; }
        public string Lines_OrderNo { get; set; }
        public string Lines_PurchaseNo { get; set; }
        public string Lines_Location { get; set; }
        public Nullable<System.DateTime> Lines_Delivery { get; set; }
        public double Lines_Ordered { get; set; }
        public double Lines_Deliver { get; set; }
        public string Lines_Unit { get; set; }
        public double Lines_Conversion { get; set; }
        public string Lines_Description { get; set; }
        public double Lines_Price { get; set; }
        public double Lines_Discount { get; set; }
        public double Lines_Amount { get; set; }
        public string Lines_Currency { get; set; }
        public double Lines_Rate { get; set; }
        public double Lines_AmmountBase { get; set; }
        public string Lines_Tax { get; set; }
        public double Lines_Delivered { get; set; }
        public double Lines_Invoiced { get; set; }
        public string Lines_ExternalNo { get; set; }
        public string Lines_BatchNo { get; set; }
        public string Lines_Customer { get; set; }
        public string Lines_Supplier { get; set; }
        public string Lines_InvoiceTo { get; set; }
        public Nullable<System.DateTime> Lines_Date { get; set; }
        public string Lines_Voucher { get; set; }
        public string Lines_Department { get; set; }
        public string Lines_CostCenter { get; set; }
        public string Lines_Purpose { get; set; }
        public string Lines_Project { get; set; }
        public string Lines_Employee { get; set; }
        public string Lines_OldOrderNo { get; set; }
        public double Lines_Quantity { get; set; }
        public double Lines_CostPrice { get; set; }
        public int Lines_Error { get; set; }
        public double Lines_CostAmount { get; set; }
        public double Lines_Trail { get; set; }
        public int Lines_RecordID { get; set; }
        public string Lines_RemarksBefore { get; set; }
        public string Lines_RemarksAfter { get; set; }
        public short Lines_AllowDiscount { get; set; }
        public short Lines_AllowFinalDiscount { get; set; }
        public bool Lines_Selected { get; set; }
        public float Lines_Weight { get; set; }
        public float Lines_Volume { get; set; }
        public short Lines_ADeliveryPacket { get; set; }
        public short Lines_EECCountry { get; set; }
        public int Lines_EECTransCode { get; set; }
        public string Lines_CostomsNo { get; set; }
        public double Lines_DutyAmount { get; set; }
        public double Lines_DutyAmountBase { get; set; }
        public string Lines_RefOrderNo { get; set; }
        public string Lines_RefPurchaseNo { get; set; }
        public double Lines_MultiplaFaktor { get; set; }
        public int Lines_MesterID { get; set; }
        public string Lines_Account { get; set; }
        public short Lines_Status { get; set; }
        public short Lines_LineNo { get; set; }
        public short Lines_FixedLine { get; set; }
        public int Lines_OldRecordID { get; set; }
        public double Lines_CostPercent { get; set; }
        public int Lines_TmpLong { get; set; }
        public bool Lines_InternalLine { get; set; }
        public string Lines_Parameter1 { get; set; }
        public string Lines_Parameter2 { get; set; }
        public short Lines_AllowDuty { get; set; }
        public string Lines_Source { get; set; }
        public double Lines_NewSalesPrice { get; set; }
        public double Lines_DeliverQuantity { get; set; }
        public double Lines_InvoiceQuantity { get; set; }
        public int Lines_Code { get; set; }
        public int Lines_BOMLineID { get; set; }
        public double Lines_Deliver_PackingList { get; set; }
        public double Lines_Amount_PackingList { get; set; }
        public double Lines_AmountBase_PackingList { get; set; }
    }
}
