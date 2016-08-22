using System;

namespace DAL
{
    public class OrderLineConnector : DbConnecter
    {
        public int DeleteOrderLine(int recordId)
        {
           return PublicOrderLineDelete(original_recordId: recordId);
        }

        private static int PublicOrderLineDelete(int? original_recordId = null, Guid? GUID = null,
            short? text_language = null, string current_userId = null)
        {
           return Db.Public_OrderLine_Delete(original_recordId, GUID, text_language, current_userId);
        }
        public void UpdateOrderLine(int originalRecordId, int originalOrdered, int ordered)
        {
           
          PublicOrderLineUpdate(original_recordId:originalRecordId,original_ordered:originalOrdered,ordered:ordered);
        }

        private static void PublicOrderLineUpdate(string account = null, short? aDeliveryPacket = null,
            short? allowDiscount = null, short? allowDuty = null, short? allowFinalDiscount = null,
            string batchNo = null,
            string costCenter = null, float? costPrice = null, string customsNo = null, float? deliver = null,
            DateTime? delivery = null, string department = null, string description = null,
            float? discount = null, string employee = null, string externalNo = null, short? fixedLine = null,
            string item = null, int? jobNo = null, string location = null, string optional1 = null,
            string optional2 = null, DateTime? optionalDate1 = null, DateTime? optionalDate2 = null,
            float? optionalNumber1 = null, float? optionalNumber2 = null, float? ordered = null,
            string parameter1 = null, string parameter2 = null, float? price = null,
            string project = null, string purpose = null, float? quantityPrColi = null, string refPurchaseNo = null,
            string remarksAfter = null, string remarksBefore = null, bool? selected = null, string tax = null,
            string unit = null, float? volume = null, float? weight = null, float? priceIncl = null,
            string original_account = null, short? original_aDeliveryPacket = null, short? original_allowDiscount = null,
            short? original_allowDuty = null, short? original_allowFinalDscount = null,
            string original_batchNo = null, string original_costCenter = null, float? original_costPrice = null,
            string original_customsNo = null, float? original_deliver = null, DateTime? original_Delivery = null,
            string original_department = null, string original_description = null, float? original_discount = null,
            string original_employee = null, string original_externalNo = null, short? original_fixedLine = null,
            string original_item = null, int? original_jobNo = null, string original_location = null,
            string original_optional1 = null, string original_optional2 = null,
            DateTime? original_optionalDate1 = null, DateTime? original_optionalDate2 = null,
            float? original_optionalNumber1 = null, float? original_optionalNumber2 = null,
            float? original_ordered = null,
            string original_parameter1 = null, string original_parameter2 = null, float? original_price = null,
            string original_project = null, string original_purpose = null, float? original_quantityPrColi = null,
            int? original_recordId = null, string original_refPurchaseNo = null, string original_remarksAfter = null,
            string original_remarksBefore = null, Boolean? original_selected = null, string original_tax = null,
            string original_unit = null, float? original_volume = null, float? original_weight = null,
            float? original_priceIncl = null, string sp_select = null, Boolean? returnNoRows = null, Guid? GUID = null,
            short? text_language = null, string current_userid = null)
        {
            Db.Public_OrderLine_Update(account, aDeliveryPacket, allowDiscount, allowDuty, allowFinalDiscount, batchNo,
                costCenter, costPrice, customsNo, deliver, delivery,
                department, description, discount, employee, externalNo, fixedLine, item, jobNo, location, optional1,
                optional2, optionalDate1, optionalDate2, optionalNumber1
                , optionalNumber2, ordered, parameter1, parameter2, price, project, purpose, quantityPrColi,
                refPurchaseNo, remarksAfter, remarksBefore, selected, tax, unit, volume, weight, priceIncl,
                original_account, original_aDeliveryPacket, original_allowDiscount, original_allowDuty,
                original_allowFinalDscount, original_batchNo, original_costCenter, original_costPrice,
                original_customsNo,
                original_deliver, original_Delivery, original_department, original_description, original_discount,
                original_employee, original_externalNo, original_fixedLine, original_item, original_jobNo
                , original_location, original_optional1, original_optional2, original_optionalDate1,
                original_optionalDate2, original_optionalNumber1, original_optionalNumber2, original_ordered,
                original_parameter1,
                original_parameter2, original_price, original_project, original_purpose, original_quantityPrColi,
                original_recordId, original_refPurchaseNo, original_remarksAfter, original_remarksBefore,
                original_selected, original_tax, original_unit, original_volume, original_weight, original_priceIncl,
                sp_select, returnNoRows, GUID, text_language, current_userid);
        }
    }
}