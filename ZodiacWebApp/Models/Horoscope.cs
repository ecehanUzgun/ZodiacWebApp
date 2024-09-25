using ZodiacWebApp.Enums;

namespace ZodiacWebApp.Models
{
    public class Horoscope
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StartMonth { get; set; }
        public int StartDay { get; set; }
        public int EndMonth { get; set; }
        public int EndDay { get; set; }
        public Element Element { get; set; } //Enum
        public List<User> User { get; set; }
        public List<UserProfile> UserProfile { get; set; }
    }
}
