using Microsoft.AspNetCore.Mvc;

namespace Udemy.Efcore.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
