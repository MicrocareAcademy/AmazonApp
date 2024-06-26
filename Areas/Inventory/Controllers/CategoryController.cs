using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Inventory.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
