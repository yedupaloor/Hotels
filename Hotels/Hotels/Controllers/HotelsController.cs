using System.Net;
using System.Web.Mvc;

namespace Hotels.Controllers
{
    public class HotelsController : Controller
    {
        HotelContext db = new HotelContext();
        public ActionResult Index()
        {
            return View();
        }
    }
}