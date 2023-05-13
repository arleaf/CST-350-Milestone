using Microsoft.AspNetCore.Mvc;
using Milestone.Models;
using Milestone.Services;

namespace Milestone.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessRegistration(UserModel user)
        { 
            SecurityService securityService = new SecurityService();
            if (securityService.IsAdded(user))
           {
               return View("RegistrationSuccess", user);
           }
            else
            {
                return View("RegistrationFailure", user);
           }
        }

    }
}
