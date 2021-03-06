﻿using System;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using BE;
using BLL;
using DAL;
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
            if (string.IsNullOrEmpty(reg.Error) && !string.IsNullOrEmpty(reg.Item?.ItemError))
                reg.Error = reg.Item.ItemError;
            if (HttpContext.Request.Params["Action"] != null &&
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                HttpContext.Request.Params["Action"] != ScanItemModel.ScanAndStop || reg.Scanned == 2) {

                return RedirectToAction(MVC.Purchase.MakePurchaseGet(reg.Target, reg.Item?.LineNo));
            }
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

        public void DeletePurchaseLine(int orderLineId)
        {
            PurchaseLineWorker plw = new PurchaseLineWorker();
            plw.DeletePurchaseLine(orderLineId);
        }

        public void UpdatePurchaseLine(int originalRecordId, int originalOrdered, int ordered)
        {
            var plw = new PurchaseLineWorker();
            plw.UpdatePurchaseLine(originalRecordId, originalOrdered, ordered);
        }

        public string GetPurchase(string id)
        {
            var pc = new PurchaseConnector();
            var purchase = pc.selectPurchase(id).FirstOrDefault();

            var json = new JavaScriptSerializer().Serialize(purchase);
            Console.Write(json);
            return json;
        }
    }
}