using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Reflection;

namespace BE
{
    public partial class KompasDemoEntities
    {
        public ObjectResult<Public_Purchases_AddNew_Result> Public_Purchases_AddNew(global::System.String supplier)
        {
            ObjectParameter SupplierParameter;
            supplier = supplier ?? string.Empty;
            SupplierParameter = new ObjectParameter("Supplier", supplier);
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Public_Purchases_AddNew_Result>("Public_Purchases_AddNew", SupplierParameter);
        }

        public ObjectResult<Public_Orders_AddNew_Result> Public_Orders_AddNew(global::System.String customer)
        {
            ObjectParameter SupplierParameter;
            customer = customer ?? string.Empty;
            SupplierParameter = new ObjectParameter("Customer", customer);
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Public_Orders_AddNew_Result>("Public_Orders_AddNew", SupplierParameter);
        }

        public int Public_OrderLine_AddNew(string item,double? ordered,string orderNo,string parameter1,string parameter2, bool? returnNoRows)
        { var parms = new List<ObjectParameter>();
            if (!string.IsNullOrEmpty(item)) parms.Add(new ObjectParameter("item", item));
            if (ordered.HasValue) parms.Add(new ObjectParameter("ordered", ordered));
            if (!string.IsNullOrEmpty(orderNo)) parms.Add(new ObjectParameter("orderNo", orderNo));
            if (!string.IsNullOrEmpty(parameter1)) parms.Add(new ObjectParameter("parameter1", parameter1));
            if (!string.IsNullOrEmpty(parameter1)) parms.Add(new ObjectParameter("parameter2", parameter2));
            if (returnNoRows.HasValue) parms.Add(new ObjectParameter("returnNoRows", returnNoRows));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Public_OrderLine_AddNew", parms.ToArray());
            
        }

        public int Public_PurchaseLine_AddNew(string item, double? ordered, string purchaseNo, string parameter1, string parameter2, bool? returnNoRows)
        {
            var parms = new List<ObjectParameter>();
            
            if(!string.IsNullOrEmpty(item)) parms.Add(new ObjectParameter("item", item));
            if(ordered.HasValue) parms.Add(new ObjectParameter("ordered", ordered));
            if(!string.IsNullOrEmpty(purchaseNo)) parms.Add(new ObjectParameter("purchaseNo", purchaseNo));
            if(!string.IsNullOrEmpty(parameter1)) parms.Add(new ObjectParameter("parameter1", parameter1));
            if (!string.IsNullOrEmpty(parameter1)) parms.Add(new ObjectParameter("parameter2", parameter2));
            if(returnNoRows.HasValue) parms.Add(new ObjectParameter("returnNoRows", returnNoRows));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Public_PurchaseLine_AddNew", parms.ToArray());
        }

        public virtual ObjectResult<string> EW_Mobil_AddInventoryCount(string param_Journal, string param_Placement, string param_Employee, string param_Item, Nullable<double> param_Quantity, string inventoryCount_Parameter1, string inventoryCount_Parameter2)
        {
            var param_JournalParameter = param_Journal != null ?
                new ObjectParameter("param_Journal", param_Journal) :
                new ObjectParameter("param_Journal", typeof(string));

           

            var param_PlacementParameter = param_Placement != null ?
                new ObjectParameter("Param_Placement", param_Placement) :
                new ObjectParameter("Param_Placement", typeof(string));

            var param_EmployeeParameter = param_Employee != null ?
                new ObjectParameter("Param_Employee", param_Employee) :
                new ObjectParameter("Param_Employee", typeof(string));

            var param_ItemParameter = param_Item != null ?
                new ObjectParameter("Param_Item", param_Item) :
                new ObjectParameter("Param_Item", typeof(string));

            var param_QuantityParameter = param_Quantity.HasValue ?
                new ObjectParameter("Param_Quantity", param_Quantity) :
                new ObjectParameter("Param_Quantity", typeof(double));

            var inventoryCount_Parameter1Parameter = inventoryCount_Parameter1 != null ?
                new ObjectParameter("InventoryCount_Parameter1", inventoryCount_Parameter1) :
                new ObjectParameter("InventoryCount_Parameter1", typeof(string));

            var inventoryCount_Parameter2Parameter = inventoryCount_Parameter2 != null ?
                new ObjectParameter("InventoryCount_Parameter2", inventoryCount_Parameter2) :
                new ObjectParameter("InventoryCount_Parameter2", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EW_Mobil_AddInventoryCount", param_JournalParameter, param_PlacementParameter, param_EmployeeParameter, param_ItemParameter, param_QuantityParameter, inventoryCount_Parameter1Parameter, inventoryCount_Parameter2Parameter);
        }
    }
}