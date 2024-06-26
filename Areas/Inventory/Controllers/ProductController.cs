using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Inventory.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
