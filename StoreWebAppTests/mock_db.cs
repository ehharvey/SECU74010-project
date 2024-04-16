using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreWebApp.Models;

namespace StoreWebAppTests
{
    public class MockDbContext : DbContext, ILoginRepository
    {
        private DbSet<Login> Logins => Set<Login>();
        public MockDbContext(DbContextOptions<MockDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().HasKey(i => i.Id);
            modelBuilder.Entity<Login>().HasData(
                new Login(-1, "test@example.com", "password")
            );
        }

        public void AddLogin(Login login)
        {
            Logins.Add(login);
        }

        public string? GetLoggedInUser()
        {
            return "mocktestuser";
        }

        public Task<string?> GetLoggedInUserAsync()
        {
            return Task.FromResult(GetLoggedInUser());
        }


        public Task AddLoginAsync(Login login)
        {
            throw new System.NotImplementedException();
        }
    }

    public class MockDb
    {
        public static DbContextOptions<MockDbContext> GetOptions()
        {
            return new DbContextOptionsBuilder<MockDbContext>()
                .UseInMemoryDatabase(databaseName: "MockDb")
                .Options;
        }
    }
}