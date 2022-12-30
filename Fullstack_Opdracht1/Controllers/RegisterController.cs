using Microsoft.AspNetCore.Mvc;
using Fullstack_Opdracht1.ViewModels;
using System.Text;

namespace Fullstack_Opdracht1.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserVM user)
        {
            if (!ModelState.IsValid)
            {
                ViewData["registrationMessage"] = "Form is invald";
                return View("Index");
            }
            StringBuilder userInfo = new StringBuilder();
            userInfo.Append(user.name).Append(" ").Append(user.firstName)
                .Append("\n")
                .Append(user.age);
            ViewBag.userInfo = userInfo;

            return View("Index", user);
        }
    }
}
