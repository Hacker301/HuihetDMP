using System.Web.Mvc;

namespace HuihetDMP.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return Content("Home/Index");
        }
    }
}