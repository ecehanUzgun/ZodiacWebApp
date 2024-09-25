namespace ZodiacWebApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //Foreign Key
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
