using System.Web.Mvc;
using System.Web.Script.Serialization;
using DAL;
using Winkompass_Mobil.Models;

namespace Winkompass_Mobil.Controllers
{
    public partial class SharedController : Controller
    {
        // GET: Shared
        //[OutputCache(Duration = 1000, VaryByParam = "none")]
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }

        public virtual ActionResult ScanWithTarget(ScanItemModel reg)
        {
            return PartialView(reg);
        }


        public string GetItems(string id)
        {
            var sc = new SharedConnector();
            var items = sc.selectItems();

            var json = new JavaScriptSerializer().Serialize(items);
            return json;
        }
    }
}