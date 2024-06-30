using AmazonApp.Areas.Account.Models;
using AmazonApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Account.Controllers
{
    [Area("Account")]
    public class LogonController : Controller
    {
        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        public IActionResult SubmitLogin(LoginModel loginmodel)
        {
            var dbcontext = new AmazonDBContext();
            User userObj = dbcontext.Users.FirstOrDefault(p => p.UserName == loginmodel.Username && p.Password == loginmodel.Password);
            if (userObj == null)
            {
                ModelState.AddModelError("", "Entered username or password is incorrect.");
                return View("Login", loginmodel);
            }
            else
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Home" });

            }
        }

        public IActionResult RegisterForm()
        {
            var model = new RegisterModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult SaveUser(RegisterModel registerModel)
        {
            var dbcontext = new AmazonDBContext();
            User NewUser = new User();
            NewUser.UserName = registerModel.Username;
            NewUser.Password = registerModel.Password;
            NewUser.EmailId = registerModel.Email;

            dbcontext.Users.Add(NewUser);
            dbcontext.SaveChanges();

            return RedirectToAction("Login");
        }
    }
}