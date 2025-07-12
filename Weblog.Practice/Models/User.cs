using System.ComponentModel.DataAnnotations;

namespace Weblog.Practice.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Length(5,25 , ErrorMessage = "Username must be betwwen 5-25 words")]
        public string? Username { get; set; }
        [Required]
        [MinLength(8)]
        public string? Password { get; set; }
        public UserProfile? Profile { get; set; }

    }
}
