﻿using System.Web.Mvc;

namespace Winkompass_Mobil.Controllers
{
    public partial class HomeController : Controller
    {
        //[OutputCache(Duration = 86400, VaryByParam = "none")]
        public virtual ActionResult Index()
        {
            ViewBag.HideBack = true;
            return View();
        }
    }
}