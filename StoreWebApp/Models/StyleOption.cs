using Microsoft.EntityFrameworkCore;

namespace StoreWebApp.Models
{
    public class StyleOption
    {
        public int Id { get; set; }
        public required string StyleName { get; set; }
        public required string StyleValue { get; set; }
    }
}