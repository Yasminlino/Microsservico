using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SimpleSearch()
        {
            return View();
        }
        public ActionResult GroupingSearch()
        {
            return View();
        }

    }
}
