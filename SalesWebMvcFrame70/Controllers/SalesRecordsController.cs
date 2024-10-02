using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvcFrame70.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SimpleSearch()
        {
            return View();
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
