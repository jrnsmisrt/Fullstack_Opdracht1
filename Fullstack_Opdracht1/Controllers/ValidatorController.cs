using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Opdracht1.Controllers
{
    public class ValidatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValidateCountry(string country)
        {
  

            if (country.ToLower() != "belgium")
            {
                return Json(false);
            }

            return Json(true);
        }
    }
}
