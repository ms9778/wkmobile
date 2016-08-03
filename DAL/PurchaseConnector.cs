using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL
{
    public class PurchaseConnector : DBConnecter
    {
        public int MakePurchase(ScanItem item)
        {
            try
            {
                if (string.IsNullOrEmpty(item.LineNo))
                { var result = db.Public_Purchases_AddNew(item.target).FirstOrDefault();
                item.LineNo = result.PurchaseNo;
                }
                //    Public_Purchases_AddNew_Result result = new Public_Purchases_AddNew_Result() { PurchaseNo = ""+400003 }; //-bruges til test
                //db.Public_PurchaseLine_AddNew(null, null, null, null, null, null, null, null, null, null, null, null, item.barCode, null, null, null, null, null, null, null, null, null, item.count, item.par1, item.par2, null, null, item.LineNo, null, null, null, null, null, null, null, null, null, true, null, null, null);
                db.Public_PurchaseLine_AddNew(item.barCode, item.count, item.LineNo, item.par1, item.par2, true);
                //return 0;
                return ScanItem.SCAN_VALID;
            }
            catch (EntityCommandExecutionException e)
            {
                Match m = Regex.Match(e.InnerException.Message, "Kreditoren '(.|\n)*' findes ikke!");
                if (m.Success)
                {
                    item.ItemError = "Ugyldig Leverandør";
                    item.target = "";

                }
                else if (item.barCode != null)
                    try
                    {
                        var dbn = new KompasDemoEntities();
                        var testItem = dbn.Inventories.Find(item.barCode);
                        if (testItem == null)
                        {
                            item.ItemError = "Ugyldig stregkode";
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                if (item.par1 != null)
                {
                    try
                    {
                        var dbn = new KompasDemoEntities();
                        var testItem = dbn.InventoryParameters.Where(x => x.Item == item.barCode && x.ParamNo == 0 && x.SortIndex == short.Parse(item.par1)).Select(x => x).SingleOrDefault();
                        if (testItem == null)
                        {
                            item.ItemError = "Parameter 1 er ugyldig";
                        }
                    }
                    catch (Exception ex)
                    {
                        item.ItemError = "Parameter 1 er ugyldig";
                    }
                }
                if (item.par2 != null)
                {
                    try
                    {
                        var dbn = new KompasDemoEntities();
                        var testItem = dbn.InventoryParameters.Where(x => x.Item == item.barCode && x.ParamNo == 1 && x.SortIndex == short.Parse(item.par2)).Select(x => x).SingleOrDefault();
                        if (testItem == null)
                        {
                            item.ItemError = "Parameter 2 er ugyldig";
                        }
                    }
                    catch (Exception ex)
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
            return (from x in db.Purchases join y in db.Suppliers on x.Supplier equals y.Supplier1 where x.Status == p select new PurchaseDetails() { PurchaseNo=x.PurchaseNo,SupplierNo=y.Supplier1,SupplierName=y.Name}).ToList();
        }
    }
}
