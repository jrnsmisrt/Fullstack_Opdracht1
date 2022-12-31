using Microsoft.AspNetCore.Mvc;
using Fullstack_Opdracht1.ViewModels;
using System.Text;
using Microsoft.AspNetCore.Authorization;

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

            /*
             ViewBag.userInfo maakt geen deel uit van de opdracht, 
             wordt louter gebruikt om geregistreerde waardes terug te geven.
             */
            ViewBag.userInfo = new Dictionary<string, string>
             {
                        { "name", user.Name },
                        { "firstname", user.FirstName },
                        { "age", user.Age.ToString() },
                        { "email", user.Email },
                        { "country", user.Country },
                        { "zipcode", user.Age.ToString() },
                        { "mobilephonenumber", user.MobilePhoneNumber }
             };

            return View("Succes", user);
        }

        [AcceptVerbs("GET", "POST")]
        [AllowAnonymous]
        public IActionResult ValidateCountry(string country)
        {
            if (!("belgium".Equals(country.ToLower())))
            {
                return Json(false);
            }
            return Json(true);
        }
    }
}
