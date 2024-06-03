using Microsoft.EntityFrameworkCore;

namespace FridaReads.Server.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Text> Text { get; set; }
    }
}
