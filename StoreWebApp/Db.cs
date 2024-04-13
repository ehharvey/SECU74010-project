using Microsoft.EntityFrameworkCore;
using StoreWebApp.Models;

namespace StoreWebApp.Components
{
    public class MyDbContext : DbContext, ILoginRepository
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        private DbSet<Login> Logins { get; set; }

        public void AddLogin(Login login)
        {
            throw new NotImplementedException();
        }

        public Task AddLoginAsync(Login login)
        {
            throw new NotImplementedException();
        }

        public string? GetLoggedInUser() => Logins.FirstOrDefault()?.Email;

        public Task<string?> GetLoggedInUserAsync()
        {
            return Task.FromResult(GetLoggedInUser());
        }

        public Login GetLogin(string email)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Login>().HasKey(i => i.Id);
            modelBuilder.Entity<Models.Login>().HasData(
                new Models.Login(-1, "test@example.com", "password")
            );
        }

        void ILoginRepository.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}