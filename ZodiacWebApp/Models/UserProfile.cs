using ZodiacWebApp.Enums;

namespace ZodiacWebApp.Models
{
    public class UserProfile
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; } //Enum
        //Foreign Key
        public int HoroscopeId { get; set; }
        public Horoscope Horoscope { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
