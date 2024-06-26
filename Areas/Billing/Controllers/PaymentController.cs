using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Billing.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
