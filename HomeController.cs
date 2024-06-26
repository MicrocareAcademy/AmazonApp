using Microsoft.AspNetCore.Mvc;

namespace AmazonApp
{
    public class HomeController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
