using Microsoft.EntityFrameworkCore;

namespace StoreWebApp.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public required string GenderName { get; set; }
    }
}