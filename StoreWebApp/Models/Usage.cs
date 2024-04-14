using Microsoft.EntityFrameworkCore;

namespace StoreWebApp.Models
{
    public class Usage
    {
        public int Id { get; set; }
        public required string UsageName { get; set; }
    }
}