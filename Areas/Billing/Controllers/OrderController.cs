using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Billing.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
