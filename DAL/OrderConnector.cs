using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using BE;

namespace DAL
{
    public class OrderConnector : DbConnecter
    {
        public int ScanOrder(ScanItem item)
        {
            try
            {
                if (string.IsNullOrEmpty(item.LineNo))
                {
                    var result = Db.Public_Orders_AddNew(item.Target).FirstOrDefault();
                    if (result != null) item.LineNo = result.OrderNo;
                }

                try
                {
                    Db.Public_OrderLine_AddNew(item.BarCode, item.Count, item.LineNo, item.Par1, item.Par2, true);

                    return ScanItem.SCAN_VALID;
                }
                catch (Exception e)
                {
                    item.ItemError = e.InnerException.Message;
                    return ScanItem.SCAN_INVALID;
                }
            }

            catch (EntityCommandExecutionException e)
            {
                var m = Regex.Match(e.InnerException.Message, "Faktura kunden '(.|\n)*' findes ikke!");
                if (m.Success)
                {
                    item.ItemError = "Ugyldig Kunde";
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
        } //Faktura kunden '343' findes ikke!

        public List<Order> GetOrdersWithStatus(string p, int t)
        {
            return Db.Orders.Where(x => x.Status == p && x.OrderType == t).Select(x => x).ToList();
        }

        public ObjectResult<Public_OrderLine_Select_All_Result> selectAllOrderLines(string id)
        {
            return Db.Public_OrderLine_Select_All(id);
        }

        public ObjectResult<Public_Orders_Select_Single_Result> selectOrder(string id)
        {
            return Db.Public_Orders_Select_Single(id,null,null);
        }
    }
}