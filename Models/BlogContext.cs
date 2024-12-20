using Microsoft.EntityFrameworkCore;

namespace MeetingApp.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Meeting> Meetings => Set<Meeting>();

       
    }
}