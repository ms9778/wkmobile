using System.Web.Mvc;

namespace Winkompass_Mobil.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            ViewBag.HideBack = true;
            return View();
        }
    }
}