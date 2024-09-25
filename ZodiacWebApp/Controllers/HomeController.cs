using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using ZodiacWebApp.Enums;
using ZodiacWebApp.Models;

namespace ZodiacWebApp.Controllers
{
    public class HomeController : Controller
    {
        static List<Horoscope> horoscopes = new List<Horoscope>()
        {
            new Horoscope { ID = 1, Name = "Aries", Element = Element.Fire, StartMonth = 3, StartDay = 21, EndMonth = 4, EndDay = 19 }, // Koç
            new Horoscope { ID = 2, Name = "Taurus", Element = Element.Earth, StartMonth = 4, StartDay = 20, EndMonth = 5, EndDay = 20 }, // Boğa 
            new Horoscope { ID = 3, Name = "Gemini", Element = Element.Air, StartMonth = 5, StartDay = 21, EndMonth = 6, EndDay = 20 },  // İkizler 
            new Horoscope { ID = 4, Name = "Cancer", Element = Element.Water, StartMonth = 6, StartDay = 21, EndMonth = 7, EndDay = 22 },  // Yengeç 
            new Horoscope { ID = 5, Name = "Leo", Element = Element.Fire, StartMonth = 7, StartDay = 23, EndMonth = 8, EndDay = 22 }, // Aslan 
            new Horoscope { ID = 6, Name = "Virgo", Element = Element.Earth, StartMonth = 8, StartDay = 23, EndMonth = 9, EndDay = 22 },  // Başak 
            new Horoscope { ID = 7, Name = "Libra", Element = Element.Air, StartMonth = 9, StartDay = 23, EndMonth = 10, EndDay = 22 },  // Terazi 
            new Horoscope { ID = 8, Name = "Scorpio", Element = Element.Water, StartMonth = 10, StartDay = 23, EndMonth = 11, EndDay = 21 },  // Akrep 
            new Horoscope { ID = 9, Name = "Sagittarius", Element = Element.Fire, StartMonth = 11, StartDay = 22, EndMonth = 12, EndDay = 21 },  // Yay 
            new Horoscope { ID = 10, Name = "Capricorn", Element = Element.Earth, StartMonth = 12, StartDay = 22, EndMonth = 1, EndDay = 19 },  // Oğlak
            new Horoscope { ID = 11, Name = "Aquarius", Element = Element.Air, StartMonth = 1, StartDay = 20, EndMonth = 2, EndDay = 18 },  // Kova 
            new Horoscope { ID = 12, Name = "Pisces", Element = Element.Water, StartMonth = 2, StartDay = 19, EndMonth = 3, EndDay = 20 }  // Balık 
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserProfile userProfile)
        {
            //NullReferenceException hatasını önlemek için
            if (userProfile.Horoscope == null)
            {
                userProfile.Horoscope = new Horoscope();
            }

            foreach (var h in horoscopes)
            {
                if ((userProfile.BirthDate.Month == h.StartMonth && userProfile.BirthDate.Day >= h.StartDay) || (userProfile.BirthDate.Month == h.EndMonth && userProfile.BirthDate.Day <= h.EndDay))
                {
                    userProfile.Horoscope.Name = h.Name; //System.NullReferenceException: 'Object reference not set to an instance of an object.'
                    break;
                }
            }
            return View(userProfile);
        }
    }
}
