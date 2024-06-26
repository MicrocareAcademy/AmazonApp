using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    public class CategoryController : Controller
    {
        public IActionResult GetCategories()
        {
            return View("CategoriesList");
        }
    }
}
