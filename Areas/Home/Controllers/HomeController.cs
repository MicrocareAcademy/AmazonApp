using AmazonApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Home.Controllers
{
    [Area("Home")]
    public class HomeController : Controller
    {
        AmazonDBContext dBContext = new AmazonDBContext();
        public IActionResult Dashboard()
        {
            var users = dBContext.Users.ToList();
            return View("Dashboard");
        }
    }
}
