using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Billing.Controllers
{
    [Area("Billing")]
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
