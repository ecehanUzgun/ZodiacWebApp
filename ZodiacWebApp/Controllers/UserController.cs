using Microsoft.AspNetCore.Mvc;
using ZodiacWebApp.Models;

namespace ZodiacWebApp.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
            new User{ ID = 1, Email = "user@gmail.com", Password = "1234"}
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User newUser)
        {
            User user = users.FirstOrDefault(x => x.Email == newUser.Email && x.Password == newUser.Password);
            if (user != null) 
            { 
                return RedirectToAction("Welcome");
            }
            return View();
        }

        public IActionResult Welcome() 
        {
            return View();
        }
    }
}
