using System;

namespace DAL
{
    public class PurchaseLineConnector : DbConnecter
    {
        public int DeletePurchaseLine(string orderLineId)
        {
            return PublicPurchaseLineDelete(orderLineId);
        }

        private static int PublicPurchaseLineDelete(string original_recordId = null, Guid? GUID = null,
            short? text_language = null, string current_userId = null)
        {
            return Db.Public_PurchaseLine_Delete(original_recordId, GUID, text_language, current_userId);
        }

        public void UpdatePurchaseLine(int originalRecordId, int originalOrdered, int ordered)
        {
            PublicPurchaseLineUpdate(original_recordId: originalRecordId, original_ordered: originalOrdered,
                ordered: ordered);
        }

        private static void PublicPurchaseLineUpdate(string account = null,
            short? allowDuty = null,
            string batchNo = null,
            string costCenter = null, string customsNo = null, float? deliver = null,
            DateTime? delivery = null, string department = null, string description = null,
            float? discount = null, string employee = null, string externalNo = null,
            string item = null, string location = null,float? newSalesPrice = null, string optional1 = null,
            string optional2 = null, DateTime? optionalDate1 = null, DateTime? optionalDate2 = null,
            float? optionalNumber1 = null, float? optionalNumber2 = null, float? ordered = null,
            string parameter1 = null, string parameter2 = null, float? price = null,
            string project = null, string purpose = null,string refOrderNo = null,
            string remarksAfter = null, string remarksBefore = null, bool? selected = null, string tax = null,
            string unit = null, float? volume = null, float? weight = null,
            string original_account = null,
            short? original_allowDuty = null,
            string original_batchNo = null, string original_costCenter = null,
            string original_customsNo = null, float? original_deliver = null, DateTime? original_Delivery = null,
            string original_department = null, string original_description = null, float? original_discount = null,
            string original_employee = null, string original_externalNo = null,
            string original_item = null, string original_location = null,
            string original_optional1 = null, string original_optional2 = null,
            DateTime? original_optionalDate1 = null, DateTime? original_optionalDate2 = null,
            float? original_optionalNumber1 = null, float? original_optionalNumber2 = null,
            float? original_ordered = null,float? original_newSalesPrice = null,
            string original_parameter1 = null, string original_parameter2 = null, float? original_price = null,
            string original_project = null, string original_purpose = null,
            int? original_recordId = null,string original_refOrderNo = null, string original_remarksAfter = null,
            string original_remarksBefore = null, bool? original_selected = null, string original_tax = null,
            string original_unit = null, float? original_volume = null, float? original_weight = null,
            bool? returnNoRows = null, Guid? GUID = null,
            short? text_language = null, string current_userid = null)
        {
            Db.Public_PurchaseLine_Update(account, allowDuty, batchNo,
                costCenter, customsNo, deliver, delivery,
                department, description, discount, employee, externalNo, item, location, newSalesPrice, optional1,
                optional2, optionalDate1, optionalDate2, optionalNumber1
                , optionalNumber2, ordered, parameter1, parameter2, price, project, purpose,
                refOrderNo, remarksAfter, remarksBefore, selected, tax, unit, volume, weight,
                original_account, original_allowDuty,
                original_batchNo, original_costCenter,
                original_customsNo,
                original_deliver, original_Delivery, original_department, original_description, original_discount,
                original_employee, original_externalNo, original_item,
                original_location, original_newSalesPrice, original_optional1, original_optional2,
                original_optionalDate1,
                original_optionalDate2, original_optionalNumber1, original_optionalNumber2, original_ordered,
                original_parameter1,
                original_parameter2, original_price, original_project, original_purpose,
                original_recordId, original_refOrderNo, original_remarksAfter, original_remarksBefore,
                original_selected, original_tax, original_unit, original_volume, original_weight,
                returnNoRows, GUID, text_language, current_userid);
        }
    }
}