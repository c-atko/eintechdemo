using System.Web.Mvc;

namespace EintechDemo.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Eintech Demo";

            return View();
        }
    }
}
