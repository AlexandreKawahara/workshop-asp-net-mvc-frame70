using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvcFrame70.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
