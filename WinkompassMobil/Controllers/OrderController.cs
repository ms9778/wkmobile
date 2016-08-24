using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using BE;
using BLL;
using DAL;
using Microsoft.Ajax.Utilities;
using Winkompass_Mobil.Code;
using Winkompass_Mobil.Models;
using System;
using System.Web.Script.Serialization;


namespace Winkompass_Mobil.Controllers
{
    
    public partial class OrderController : Controller
    {
        Functions func = new Functions();    
        // GET: CreateOrder
        //[OutputCache(Duration = 1000, VaryByParam = "none")]
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }


        [ActionName("CreateOrder")]
        public virtual ActionResult OrderGet(string cus, string on)
        {
            var reg = new ScanItemModel {Item = new ScanItem {Target = cus, LineNo = on}};
            return View(reg);
        }

        [HttpPost]
        public virtual ActionResult CreateOrder(ScanItemModel reg)
        {
            if (reg?.Item != null)
            {
                if (string.IsNullOrEmpty(reg.Item.BarCode) || string.IsNullOrEmpty(reg.Item.Target))
                {
                    reg.Error = "Kunne ikke aflæse scanningen.";
                    return View(reg);
                }
                if (reg.Item.Count < 1)
                {
                    reg.Error = "Ugyldigt tal opgivet under \"Antal optalt\"";
                    return View(reg);
                }
                
            }
            if (reg?.Item?.BarCode != null && reg.Item.Count > 0)
                reg.Scanned = OrderWorker.MakeOrder(reg.Item);
            if (reg != null && (string.IsNullOrEmpty(reg.Error) && !string.IsNullOrEmpty(reg.Item.ItemError)))
                reg.Error = reg.Item.ItemError;
            if (HttpContext.Request.Params["Action"] != null &&
                HttpContext.Request.Params["Action"] != ScanItemModel.ScanAndStop || reg.Scanned == 2)
            {
                return RedirectToAction(MVC.Order.OrderGet(reg.Target,reg.Item.LineNo));
            }
            return RedirectToAction(MVC.Order.OrderList());
        }

        //[OutputCache(Duration = 100, VaryByParam = "none")]
        public virtual ActionResult OrderList()
        {
            var model = new OrderListModel
            {
                Orders = OrderWorker.GetCurrentOrders(ConfigurationManager.AppSettings["orderStatus"],
                    int.Parse(ConfigurationManager.AppSettings["orderType"]))
            };

            model.Orders.Reverse();
            return View(model);
        }

        public void  DeleteOrderLine(int orderLineId)
        {
            OrderLineWorker olw = new OrderLineWorker();
            olw.DeleteOrderLine(orderLineId);
        }

        public void UpdateOrderLine(int originalRecordId,int originalOrdered, int ordered)
        {
            var olw = new OrderLineWorker();
            olw.UpdateOrderLine(originalRecordId,originalOrdered,ordered);
        }

        public string GetOrder(string id)
        {
            var oc = new OrderConnector();
            var order = oc.selectOrder(id).FirstOrDefault();

            var json = new JavaScriptSerializer().Serialize(order);
            Console.Write(json);
            return json;       
        }

    }
}