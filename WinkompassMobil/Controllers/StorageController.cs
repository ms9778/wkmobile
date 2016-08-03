
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using Winkompass_Mobil.Models;
using BLL;
using BE;

namespace Winkompass_Mobil.Controllers
{
    public partial class StorageController : Controller
    {
        // GET: Storage
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }

        [HttpGet]
        public virtual ActionResult CreateTemplate()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult CreateTemplate(TemplateModel KModel)
        {
            if (KModel != null && KModel.Template != null)
            {
                var allJournals = StorageWorker.GetAllStockJournals();
                    
                     foreach (var item in allJournals)
                     {
                         if(item.Journal1 == KModel.Template.Journal1) {
                             KModel.Error = "Kladden er allerede lavet";
                             return View(KModel);
                         };
                         break;
                     }
            
                     if (!string.IsNullOrEmpty(KModel.Template.Journal1))
                     {
                         KModel.Created = false;
                         //Bogstaver tal samt tegnene .-@ er tilladte med denne regular expression (samt mellemrum)
                         Match m = Regex.Match(KModel.Template.Journal1, @"[^a-zA-Z0-9æøåÆØÅ\.\-@ ]+");
                         if (m.Success)
                         {
                             KModel.Error = "Kladden indeholder Ugyldige tegn, gyldige tegn er: a-å 0-9 .-@";
                             return View(KModel);
                         }
                     }
                     KModel.Created = StorageWorker.CreateJournal(KModel.Template);
            }
            KModel = KModel ?? new TemplateModel();



            return View(KModel);
        }

        public virtual ActionResult StorageCount(string id)
        {
            if (!IsValidTemplate(id))
            {
                SessionManager.Manager.IgnoreAction = true;
                return RedirectToAction(MVC.Storage.ChoseTemplate());
            }
            return View();
        }
        [HttpPost]
        public virtual ActionResult StorageCount(string id, ScanItemModel reg)
        {
            if (!IsValidTemplate(id))
            {
                SessionManager.Manager.IgnoreAction = true;
                return RedirectToAction(MVC.Storage.ChoseTemplate());
            }
            reg = reg ?? new ScanItemModel();
            reg.item.Journal = id;
            if (reg != null && reg.item != null)
            {
                if (string.IsNullOrEmpty(reg.item.barCode))
                {
                    reg.Error = "Ingenting blev scannet";
                    return View(reg);
                }
                else if (reg.item.count < 0)
                {
                    reg.Error = "Ugyldigt tal opgivet under \"Antal optalt\"";
                    return View(reg);
                }
            }
            if (reg.item != null && reg.item.barCode != null && reg.item.count >= 0)
                reg.scanned = ScanItem(reg);
            if (string.IsNullOrEmpty(reg.Error) && !string.IsNullOrEmpty(reg.item.ItemError))
                reg.Error = reg.item.ItemError;
            if (reg.scanned == BE.ScanItem.SCAN_VALID)
            {
                reg.message = reg.item.count + " vare(r) med varenummer " + reg.item.barCode + " blev registreret!" + (reg.item != null && reg.item.showDifference ? " Med en forskel på: " + reg.item.difference : "");
            }
            if (HttpContext.Request.Params["Action"] != null && HttpContext.Request.Params["Action"] != ScanItemModel.SCAN_AND_STOP || reg.scanned == 2)
                return View(reg);
            return RedirectToAction(MVC.Home.Index());
        }



        public virtual ActionResult ChoseTemplate()
        {
            TemplateList list = new TemplateList();
            list.Journals = StorageWorker.GetAllStockJournals();
            return View(list);
        }

        public virtual ActionResult QuickCount(string id)
        {
            if (!IsValidTemplate(id))
            {
                SessionManager.Manager.IgnoreAction = true;
                return RedirectToAction(MVC.Storage.ChoseTemplate());
            }
            return View();
        }

        [HttpPost]
        public virtual JsonResult QuickCount(string id, ScanItemModel reg)
        {

            reg = reg ?? new ScanItemModel();
            reg.item.Journal = id;
            if (!string.IsNullOrEmpty(reg.item.barCode))
                reg.scanned = ScanItem(id, reg.item.barCode, reg);
            else
            {
                reg.Error = "Ingenting blev scannet";
            }
            if (string.IsNullOrEmpty(reg.Error) && !string.IsNullOrEmpty(reg.item.ItemError))
                reg.Error = reg.item.ItemError;
            return Json(reg);
        }

        private int ScanItem(ScanItemModel reg = null)
        {
            reg = reg ?? new ScanItemModel();
            return StorageWorker.ScanItem(reg.item);
        }

        private int ScanItem(string journal, string barCode, ScanItemModel reg = null, int count = 1)
        {
            reg = reg ?? new ScanItemModel();

            ScanItem item = new ScanItem();
            item.Journal = journal;
            item.barCode = barCode;
            item.count = count;
            reg.item = item;
            return ScanItem(reg);
        }

        public virtual ActionResult Top5(string id)
        {
            var model = new ScannedItemsModel();
            model.items = StorageWorker.retrieveLastRecords(id);
            return PartialView(model);
        }

        public Boolean IsValidTemplate(string id)
        {
            return StorageWorker.IsValidTemplate(id);
        }
    }
}