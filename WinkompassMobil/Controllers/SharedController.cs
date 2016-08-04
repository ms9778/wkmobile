using System.Web.Mvc;
using Winkompass_Mobil.Models;

namespace Winkompass_Mobil.Controllers
{
    public partial class SharedController : Controller
    {
        // GET: Shared
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }

        public virtual ActionResult ScanWithTarget(ScanItemModel reg)
        {
            return PartialView(reg);
        }
    }
}