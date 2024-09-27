using Microsoft.AspNetCore.Mvc;
using ZodiacWebApp.Models;

namespace ZodiacWebApp.Controllers
{
    public class UserProfileController : Controller
    {
        static List<UserProfile> userProfiles = new List<UserProfile>()
        {
            new UserProfile{ ID = 1 , Firstname = "Ecehan", Lastname = "Üzgün"}
        };

        public IActionResult Index()
        {
            return View(userProfiles);
        }

        //UserProfile CRUD 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserProfile userProfile)
        {
            userProfile.ID = userProfiles.Count+1;
            userProfiles.Add(userProfile);
            return RedirectToAction("Index");
        }

        public IActionResult GetUserProfileById(int id) 
        { 
            UserProfile userProfile = userProfiles.FirstOrDefault(x => x.ID == id);
            if (userProfile != null)
            {
                return View(userProfile);
            }
            return RedirectToAction("Index"); 
        }

        public IActionResult Update(int id)
        { 
            return View(); 
        }
    }
}
