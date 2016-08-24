using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text.RegularExpressions;
using BE;

namespace DAL
{
    public class PurchaseConnector : DbConnecter
    {
        public int MakePurchase(ScanItem item)
        {
            try
            {
                if (string.IsNullOrEmpty(item.LineNo))
                {
                    var result = Db.Public_Purchases_AddNew(item.Target).FirstOrDefault();
                    if (result != null) item.LineNo = result.PurchaseNo;
                }
                Db.Public_PurchaseLine_AddNew(item.BarCode, item.Count, item.LineNo, item.Par1, item.Par2, true);
                return ScanItem.SCAN_VALID;
            }
            catch (EntityCommandExecutionException e)
            {
                var m = Regex.Match(e.InnerException.Message, "Kreditoren '(.|\n)*' findes ikke!");
                if (m.Success)
                {
                    item.ItemError = "Ugyldig Leverandør";
                    item.Target = "";
                }
                else if (item.BarCode != null)
                    try
                    {
                        var dbn = new KompasDemoEntities();
                        var testItem = dbn.Inventories.Find(item.BarCode);
                        if (testItem == null)
                        {
                            item.ItemError = "Ugyldig stregkode";
                        }
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                if (item.Par1 != null)
                {
                    try
                    {
                        var dbn = new KompasDemoEntities();
                        var testItem =
                            dbn.InventoryParameters.Where(
                                x => x.Item == item.BarCode && x.ParamNo == 0 && x.SortIndex == short.Parse(item.Par1))
                                .Select(x => x)
                                .SingleOrDefault();
                        if (testItem == null)
                        {
                            item.ItemError = "Parameter 1 er ugyldig";
                        }
                    }
                    catch (Exception)
                    {
                        item.ItemError = "Parameter 1 er ugyldig";
                    }
                }
                if (item.Par2 != null)
                {
                    try
                    {
                        var dbn = new KompasDemoEntities();
                        var testItem =
                            dbn.InventoryParameters.Where(
                                x => x.Item == item.BarCode && x.ParamNo == 1 && x.SortIndex == short.Parse(item.Par2))
                                .Select(x => x)
                                .SingleOrDefault();
                        if (testItem == null)
                        {
                            item.ItemError = "Parameter 2 er ugyldig";
                        }
                    }
                    catch (Exception)
                    {
                        item.ItemError = "Parameter 2 er ugyldig";
                    }
                }
                if (string.IsNullOrEmpty(item.ItemError))
                    item.ItemError = "Ukendt fejl, kontakt systemadministrator";
                return ScanItem.SCAN_INVALID;
            }
            //Kreditoren 'sss' findes ikke!
        }


        public List<PurchaseDetails> GetPurchasesWithStatus(string p)
        {
            return (from x in Db.Purchases join y in Db.Suppliers on x.Supplier equals y.Supplier1
                where x.Status == p
                select new PurchaseDetails {PurchaseNo = x.PurchaseNo, SupplierNo = y.Supplier1, SupplierName = y.Name, SupplierEmail = y.Email, SupplierPhone = y.Phone
                })
                .ToList();
        }
        public ObjectResult<Public_PurchaseLine_Select_All_Result> selectAllPurchaseLines(string id)
        {
            return Db.Public_PurchaseLine_Select_All(id);
        }
        public ObjectResult<Public_Purchases_Select_Single_Result> selectPurchase(string id)
        {
            return Db.Public_Purchases_Select_Single(id, null, null);
        }
    }
}