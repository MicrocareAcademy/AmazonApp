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

        public IActionResult GetDell()
        {
            return View("ViewDell");
        }

        public IActionResult GetHP()
        {
            return View("ViewHP");
        }

        public IActionResult GetLenovo()
        {
            return View("ViewLenovo");
        }
    }
}
