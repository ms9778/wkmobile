using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderConnector : DBConnecter
    {

        public int ScanOrder(ScanItem item)
        {
            try
            {
                if (string.IsNullOrEmpty(item.LineNo))
                { var result = db.Public_Orders_AddNew(item.target).FirstOrDefault();
                item.LineNo = result.OrderNo;
                }
            //db.Public_OrderLine_AddNew(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, item.barCode, null, null, null, null, null, null, null, null, null, null, null, item.count, item.LineNo, item.par1, item.par2, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, true, null, null, null);
            db.Public_OrderLine_AddNew(item.barCode, item.count, item.LineNo, item.par1, item.par2, true);
            //return 0;
            return ScanItem.SCAN_VALID;
            }
            catch (EntityCommandExecutionException e)
            {
                Match m = Regex.Match(e.InnerException.Message, "Faktura kunden '(.|\n)*' findes ikke!");
                if (m.Success)
                {
                    item.ItemError = "Ugyldig Kunde";
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
        }//Faktura kunden '343' findes ikke!

        public List<Order> GetOrdersWithStatus(string p,int t)
        {
            return db.Orders.Where(x => x.Status == p && x.OrderType==t).Select(x => x).ToList();
        }
    }
}
