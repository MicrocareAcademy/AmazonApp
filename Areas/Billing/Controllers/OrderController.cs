using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Billing.Controllers
{
    [Area("Billing")]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
