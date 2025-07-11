namespace Weblog.Practice.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string ?ProfileUrl { get; set; }
        public long bio { get; set; }
        public List<string> ?SocialLinks { get; set; }
        public User ?User { get; set; }
    }
}
