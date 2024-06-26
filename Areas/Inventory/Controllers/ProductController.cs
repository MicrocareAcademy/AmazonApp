using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View("ProductList");
        }
    }
}
