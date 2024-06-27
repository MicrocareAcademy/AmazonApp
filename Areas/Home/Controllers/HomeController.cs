using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Home.Controllers
{
    [Area("Home")]
    public class HomeController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
