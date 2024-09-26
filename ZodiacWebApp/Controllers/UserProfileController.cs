using Microsoft.AspNetCore.Mvc;

namespace ZodiacWebApp.Controllers
{
    public class UserProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
