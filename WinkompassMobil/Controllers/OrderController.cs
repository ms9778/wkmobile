using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Winkompass_Mobil.Models;
using BLL;
using BE;

namespace Winkompass_Mobil.Controllers
{
    public partial class OrderController : Controller
    {
        // GET: Order
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }


        [ActionName("Order")]
        public virtual ActionResult OrderGet(string cus, string on)
        {
            var reg = new  ScanItemModel() { item = new ScanItem() { target=cus,LineNo=on } };
            return View(reg);
        }

        [HttpPost]
        public virtual ActionResult Order(ScanItemModel reg)
        {
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
                reg.scanned = OrderWorker.MakeOrder(reg.item);
            if (string.IsNullOrEmpty(reg.Error) && !string.IsNullOrEmpty(reg.item.ItemError))
                reg.Error = reg.item.ItemError;
            if (HttpContext.Request.Params["Action"] != null && HttpContext.Request.Params["Action"] != ScanItemModel.SCAN_AND_STOP || reg.scanned == 2)
                return View(reg);
            return RedirectToAction(MVC.Home.Index());
        }

        public virtual ActionResult OrderList()
        {
            var model = new OrderListModel();
            model.orders = OrderWorker.GetCurrentOrders(System.Configuration.ConfigurationManager.AppSettings["orderStatus"], Int32.Parse(System.Configuration.ConfigurationManager.AppSettings["orderType"]));

            model.orders.Reverse();
            return View(model);
        }

    }
}