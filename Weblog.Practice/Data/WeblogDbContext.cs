using Microsoft.EntityFrameworkCore;
using Weblog.Practice.Models;

namespace Weblog.Practice.Data
{
    public class WeblogDbContext : DbContext
    {
        public WeblogDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }
    }
}
