using Microsoft.AspNetCore.Mvc;

namespace CustomerApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
