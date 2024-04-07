using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

// A Login is a user's credentials (email and password)
namespace SECU74010_project.Models
{
    public class Login
    {
        // make constructor private to prevent instantiation without parameters
        private Login() {
            Email = "";
            Password = "";
        }

        // constructor for seeding data
        public Login(int id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }

        public Login(string email, string password)
        {
            Email = email;
            Password = password;
        }

        [Key]
        public int Id { get; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}