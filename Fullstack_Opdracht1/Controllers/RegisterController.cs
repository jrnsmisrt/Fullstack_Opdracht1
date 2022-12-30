using Microsoft.AspNetCore.Mvc;
using Fullstack_Opdracht1.ViewModels;

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
            if(!ModelState.IsValid)
            {
                ViewData["registrationMessage"] = "Form is invald";
                return View();
            }


            return View("Index", user);
        }
    }
}
