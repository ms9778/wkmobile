using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.WebPages;
using BE;
using BLL;
using Winkompass_Mobil.Code;
using Winkompass_Mobil.Models;

namespace Winkompass_Mobil.Controllers
{
    public partial class StorageController : Controller
    {
        public Functions Function { get; } = new Functions();

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
        public virtual ActionResult CreateTemplate(TemplateModel kModel)
        {
            //Check if the Template is null
            if (kModel.Template != null)
            {
                //Check if variable contains the name that is already in the database
                var allJournals = StorageWorker.GetAllStockJournals();

                    foreach (var item in allJournals)
                    {
                        if (item.Journal1 == kModel.Template.Journal1)
                        {
                            kModel.Error = "Kladden er allerede lavet";
                            return View(kModel);
                        }
                        
                    }

                    //check if string contains something
                    if (!string.IsNullOrEmpty(kModel.Template.Journal1))
                    {
                        //The object hasnt been created yet
                        kModel.Created = false;
                        //Check if the string contains any illegal characters
                        var m = Regex.Match(kModel.Template.Journal1, @"[^a-zA-Z0-9æøåÆØÅ\.\-@ ]+");
                        //If it does return error and return the view
                        if (m.Success)
                        {
                            kModel.Error = "Kladden indeholder Ugyldige tegn, gyldige tegn er: a-å 0-9 .-@";
                            return View(kModel);
                        }
                    }
                    //Create the object
                    kModel.Created = StorageWorker.CreateJournal(kModel.Template);
               }
            else
            {
                kModel = kModel ?? new TemplateModel();
            }
            var list = new TemplateList { Journals = StorageWorker.GetAllStockJournals() };

            //return View(kModel);
            return View("StorageList", list);
        }

        public virtual ActionResult StorageCount(string id)
        {
            if (!IsValidTemplate(id))
            {
                SessionManager.Manager.IgnoreAction = true;
                return RedirectToAction(MVC.Storage.StorageList());
            }
            var reg = new ScanItemModel { storageId = id};
            return View(reg);
        }

        [HttpPost]
        public virtual ActionResult StorageCount(string id, ScanItemModel reg)
        {
            if (!IsValidTemplate(id))
            {
                SessionManager.Manager.IgnoreAction = true;
                return RedirectToAction(MVC.Storage.StorageList());
            }
            reg = reg ?? new ScanItemModel();
            reg.Item.Journal = id;
            if (reg.Item != null)
            {
                if (string.IsNullOrEmpty(reg.Item.BarCode))
                {
                    reg.Error = "Ingenting blev scannet";
                    return View(reg);
                }
                if (reg.Item.Count < 0)
                {
                    reg.Error = "Ugyldigt tal opgivet under \"Antal optalt\"";
                    return View(reg);
                }
            }
            if (reg.Item?.BarCode != null && reg.Item.Count >= 0)
                reg.Scanned = ScanItem(reg);
            if (reg.Item != null && string.IsNullOrEmpty(reg.Error) && !string.IsNullOrEmpty(reg.Item.ItemError))
                reg.Error = reg.Item.ItemError;
            if (reg.Scanned == BE.ScanItem.SCAN_VALID)
            {
                if (reg.Item != null)
                    reg.Message = reg.Item.Count + " vare(r) med varenummer " + reg.Item.BarCode + " blev registreret!" +
                                  (reg.Item != null && reg.Item.ShowDifference
                                      ? " Med en forskel på: " + reg.Item.Difference
                                      : "");
                
            }
            if (HttpContext.Request.Params["Action"] != null &&
                HttpContext.Request.Params["Action"] != ScanItemModel.ScanAndStop || reg.Scanned == 2)
                reg.storageId = id;
                return View(reg);
            return RedirectToAction(MVC.Home.Index());
        }


        public virtual ActionResult StorageList()
        {
            var list = new TemplateList {Journals = StorageWorker.GetAllStockJournals()}; 
            return View(list);
        }

        [HttpPost]
        public virtual ActionResult StorageList(TemplateModel kModel)
        {
            //Check if the Template is null
            if (kModel.Template != null)
            {
                //Check if variable contains the name that is already in the database
                var allJournals = StorageWorker.GetAllStockJournals();

                foreach (var item in allJournals)
                {
                    if (item.Journal1 == kModel.Template.Journal1)
                    {
                        kModel.Error = "Kladden er allerede lavet";
                        return View(kModel);
                    }

                }

                //check if string contains something
                if (!string.IsNullOrEmpty(kModel.Template.Journal1))
                {
                    //The object hasnt been created yet
                    kModel.Created = false;
                    //Check if the string contains any illegal characters
                    var m = Regex.Match(kModel.Template.Journal1, @"[^a-zA-Z0-9æøåÆØÅ\.\-@ ]+");
                    //If it does return error and return the view
                    if (m.Success)
                    {
                        kModel.Error = "Kladden indeholder Ugyldige tegn, gyldige tegn er: a-å 0-9 .-@";
                        return View(kModel);
                    }
                }
                //Create the object
                kModel.Created = StorageWorker.CreateJournal(kModel.Template);
            }
            else
            {
                kModel = kModel ?? new TemplateModel();
            }
            var list = new TemplateList { Journals = StorageWorker.GetAllStockJournals() };

            //return View(kModel);
            return View("StorageList", list);
        }

        public virtual ActionResult QuickCount(string id)
        {
            if (!IsValidTemplate(id))
            {
                SessionManager.Manager.IgnoreAction = true;
                return RedirectToAction(MVC.Storage.StorageList());
            }
            var reg = new ScanItemModel { storageId = id };

            return View(reg);
        }

        [HttpPost]
        public virtual JsonResult QuickCount(string id, ScanItemModel reg)
        {
            reg = reg ?? new ScanItemModel();
            reg.Item.Journal = id;
            if (!string.IsNullOrEmpty(reg.Item.BarCode))
                reg.Scanned = ScanItem(id, reg.Item.BarCode, reg);
            else
            {
                reg.Error = "Ingenting blev scannet";
            }
            if (string.IsNullOrEmpty(reg.Error) && !string.IsNullOrEmpty(reg.Item.ItemError))
                reg.Error = reg.Item.ItemError;
            return Json(reg);
        }

        private int ScanItem(ScanItemModel reg = null)
        {
            reg = reg ?? new ScanItemModel();
            return StorageWorker.ScanItem(reg.Item);
        }

        private int ScanItem(string journal, string barCode, ScanItemModel reg = null, int count = 1)
        {
            reg = reg ?? new ScanItemModel();

            var item = new ScanItem
            {
                Journal = journal,
                BarCode = barCode,
                Count = count
            };
            reg.Item = item;
            return ScanItem(reg);
        }

        public virtual ActionResult Top5(string id)
        {
            var model = new ScannedItemsModel {Items = StorageWorker.RetrieveLastRecords(id)};
            return PartialView(model);
        }

        public bool IsValidTemplate(string id)
        {
            return StorageWorker.IsValidTemplate(id);
        }
    }
}