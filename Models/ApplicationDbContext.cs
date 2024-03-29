using Microsoft.EntityFrameworkCore;

namespace LLoading.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base (options)
        {}

        public DbSet<User> Users {get; set; }

        public DbSet<Post> Posts {get; set; }
    }
}