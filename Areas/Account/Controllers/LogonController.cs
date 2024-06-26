using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Account.Controllers
{
    [Area("Account")]
    public class LogonController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
