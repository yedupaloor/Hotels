using System.Web.Mvc;

namespace Hotels.Controllers
{
    public class HotelsController : Controller
    {
        private HotelContext db = new HotelContext();
        public ActionResult Index()
        {
            return View();
        }
       
    }
}