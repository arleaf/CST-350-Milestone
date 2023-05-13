using Microsoft.AspNetCore.Mvc;

namespace Milestone.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
