using Microsoft.EntityFrameworkCore;

namespace SECU74010_project.Components
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Login> Logins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Login>().HasKey(i => i.Id);
            modelBuilder.Entity<Models.Login>().HasData(
                new Models.Login(-1, "test@example.com", "password")
            );
        }
    }
}