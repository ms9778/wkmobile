using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Winkompass_Mobil.Models;

namespace Winkompass_Mobil.Controllers
{
    public partial class PurchaseController : Controller
    {
        // GET: Purchase
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }


        [ActionName("MakePurchase")]
        public virtual ActionResult MakePurchaseGet(string sup,string supNo)
        {
            var reg = new ScanItemModel() { item = new ScanItem() { target=sup,LineNo=supNo} };
            return View(reg);
        }

        [HttpPost]
        public virtual ActionResult MakePurchase(ScanItemModel reg)
        {
            reg = reg ?? new ScanItemModel();
            if (reg != null && reg.item != null)
            {
                if (string.IsNullOrEmpty(reg.item.barCode))
                {

                    reg.Error = "Ingenting blev scannet";
                    return View(reg);
                }
                else if (reg.item.count < 1)
                {
                    reg.Error = "Ugyldigt tal opgivet under \"Antal optalt\"";
                    return View(reg);
                }
                else if (string.IsNullOrEmpty(reg.item.target))
                {
                    reg.Error = "ingen kunde scannet";
                }
            }
            if (reg.item != null && reg.item.barCode != null && reg.item.count > 0)
                reg.scanned = PurchaseWorker.MakePurchase(reg.item);
            if (string.IsNullOrEmpty(reg.Error) && !string.IsNullOrEmpty(reg.item.ItemError))
                reg.Error = reg.item.ItemError;
            if (HttpContext.Request.Params["Action"] != null && HttpContext.Request.Params["Action"] != ScanItemModel.SCAN_AND_STOP || reg.scanned == 2)
                return View(reg);
            return RedirectToAction(MVC.Home.Index());
        }

        public virtual ActionResult PurchaseList()
        {
            var list = new PurchaseListModel();
            list.purchases = PurchaseWorker.GetPurchasesWithStatus(System.Configuration.ConfigurationManager.AppSettings["purchaseStatus"]);
            list.purchases.Reverse();
            return View(list);
        }
       
        
    }
}