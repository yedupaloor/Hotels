using System.Net;
using System.Web.Mvc;

namespace Hotels.Controllers
{
    public class HotelsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}