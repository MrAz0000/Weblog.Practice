﻿namespace Weblog.Practice.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string ?ProfileUrl { get; set; }
        public string ?bio { get; set; }
        public List<string> ?SocialLinks { get; set; }

        public int ?UserId { get; set; }
        public User ?User { get; set; }
    }
}
