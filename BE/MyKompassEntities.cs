using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace BE
{
    public partial class KompasDemoEntities
    {
        public ObjectResult<Public_Purchases_AddNew_Result> Public_Purchases_AddNew(string supplier)
        {
            supplier = supplier ?? string.Empty;
            var supplierParameter = new ObjectParameter("Supplier", supplier);
            return
                ((IObjectContextAdapter) this).ObjectContext.ExecuteFunction<Public_Purchases_AddNew_Result>(
                    "Public_Purchases_AddNew", supplierParameter);
        }

        public ObjectResult<Public_Orders_AddNew_Result> Public_Orders_AddNew(string customer)
        {
            customer = customer ?? string.Empty;
            var supplierParameter = new ObjectParameter("Customer", customer);
            return
                ((IObjectContextAdapter) this).ObjectContext.ExecuteFunction<Public_Orders_AddNew_Result>(
                    "Public_Orders_AddNew", supplierParameter);
        }

        public int Public_OrderLine_AddNew(string item, double? ordered, string orderNo, string parameter1,
            string parameter2, bool? returnNoRows)
        {
            var parms = new List<ObjectParameter>();
            if (!string.IsNullOrEmpty(item)) parms.Add(new ObjectParameter("item", item));
            if (ordered.HasValue) parms.Add(new ObjectParameter("ordered", ordered));
            if (!string.IsNullOrEmpty(orderNo)) parms.Add(new ObjectParameter("orderNo", orderNo));
            if (!string.IsNullOrEmpty(parameter1)) parms.Add(new ObjectParameter("parameter1", parameter1));
            if (!string.IsNullOrEmpty(parameter1)) parms.Add(new ObjectParameter("parameter2", parameter2));
            if (returnNoRows.HasValue) parms.Add(new ObjectParameter("returnNoRows", returnNoRows));

            return ((IObjectContextAdapter) this).ObjectContext.ExecuteFunction("Public_OrderLine_AddNew",
                parms.ToArray());
        }

        public int Public_PurchaseLine_AddNew(string item, double? ordered, string purchaseNo, string parameter1,
            string parameter2, bool? returnNoRows)
        {
            var parms = new List<ObjectParameter>();

            if (!string.IsNullOrEmpty(item)) parms.Add(new ObjectParameter("item", item));
            if (ordered.HasValue) parms.Add(new ObjectParameter("ordered", ordered));
            if (!string.IsNullOrEmpty(purchaseNo)) parms.Add(new ObjectParameter("purchaseNo", purchaseNo));
            if (!string.IsNullOrEmpty(parameter1)) parms.Add(new ObjectParameter("parameter1", parameter1));
            if (!string.IsNullOrEmpty(parameter1)) parms.Add(new ObjectParameter("parameter2", parameter2));
            if (returnNoRows.HasValue) parms.Add(new ObjectParameter("returnNoRows", returnNoRows));

            return ((IObjectContextAdapter) this).ObjectContext.ExecuteFunction("Public_PurchaseLine_AddNew",
                parms.ToArray());
        }

        public virtual ObjectResult<string> EW_Mobil_AddInventoryCount(string paramJournal, string paramPlacement,
            string paramEmployee, string paramItem, double? paramQuantity, string inventoryCountParameter1,
            string inventoryCountParameter2)
        {
            var paramJournalParameter = paramJournal != null
                ? new ObjectParameter("param_Journal", paramJournal)
                : new ObjectParameter("param_Journal", typeof(string));


            var paramPlacementParameter = paramPlacement != null
                ? new ObjectParameter("Param_Placement", paramPlacement)
                : new ObjectParameter("Param_Placement", typeof(string));

            var paramEmployeeParameter = paramEmployee != null
                ? new ObjectParameter("Param_Employee", paramEmployee)
                : new ObjectParameter("Param_Employee", typeof(string));

            var paramItemParameter = paramItem != null
                ? new ObjectParameter("Param_Item", paramItem)
                : new ObjectParameter("Param_Item", typeof(string));

            var paramQuantityParameter = paramQuantity.HasValue
                ? new ObjectParameter("Param_Quantity", paramQuantity)
                : new ObjectParameter("Param_Quantity", typeof(double));

            var inventoryCountParameter1Parameter = inventoryCountParameter1 != null
                ? new ObjectParameter("InventoryCount_Parameter1", inventoryCountParameter1)
                : new ObjectParameter("InventoryCount_Parameter1", typeof(string));

            var inventoryCountParameter2Parameter = inventoryCountParameter2 != null
                ? new ObjectParameter("InventoryCount_Parameter2", inventoryCountParameter2)
                : new ObjectParameter("InventoryCount_Parameter2", typeof(string));

            return ((IObjectContextAdapter) this).ObjectContext.ExecuteFunction<string>("EW_Mobil_AddInventoryCount",
                paramJournalParameter, paramPlacementParameter, paramEmployeeParameter, paramItemParameter,
                paramQuantityParameter, inventoryCountParameter1Parameter, inventoryCountParameter2Parameter);

        }

    }
}