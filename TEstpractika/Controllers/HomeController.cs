using Microsoft.AspNetCore.Mvc;

namespace TEstpractika.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
