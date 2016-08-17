using System.Configuration;
using System.Web.Mvc;
using BE;
using BLL;
using Winkompass_Mobil.Models;

namespace Winkompass_Mobil.Controllers
{
    public partial class PurchaseController : Controller
    {

        // GET: Purchase
        //[OutputCache(Duration = 1000, VaryByParam = "none")]
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }


        [ActionName("MakePurchase")]
        public virtual ActionResult MakePurchaseGet(string sup, string supNo)
        {
            var reg = new ScanItemModel {Item = new ScanItem {Target = sup, LineNo = supNo}};
            return View(reg);
        }

        [HttpPost]
        public virtual ActionResult MakePurchase(ScanItemModel reg)
        {
            reg = reg ?? new ScanItemModel();
            if (reg.Item != null)
            {
                if (string.IsNullOrEmpty(reg.Item.BarCode))
                {
                    reg.Error = "Ingenting blev scannet";
                    return View(reg);
                }
                if (reg.Item.Count < 1)
                {
                    reg.Error = "Ugyldigt tal opgivet under \"Antal optalt\"";
                    return View(reg);
                }
                if (string.IsNullOrEmpty(reg.Item.Target))
                {
                    reg.Error = "ingen kunde scannet";
                }
            }
            if (reg.Item?.BarCode != null && reg.Item.Count > 0)
                reg.Scanned = PurchaseWorker.MakePurchase(reg.Item);
            if (string.IsNullOrEmpty(reg.Error) && !string.IsNullOrEmpty(reg.Item.ItemError))
                reg.Error = reg.Item.ItemError;
            if (HttpContext.Request.Params["Action"] != null &&
                HttpContext.Request.Params["Action"] != ScanItemModel.ScanAndStop || reg.Scanned == 2)
                return View(reg);
            return RedirectToAction(MVC.Purchase.PurchaseList());
        }

        //[OutputCache(Duration = 100, VaryByParam = "none")]
        public virtual ActionResult PurchaseList()
        {
            var list = new PurchaseListModel
            {
                Purchases = PurchaseWorker.GetPurchasesWithStatus(ConfigurationManager.AppSettings["purchaseStatus"])
            };
            list.Purchases.Reverse();
            return View(list);
        }
    }
}