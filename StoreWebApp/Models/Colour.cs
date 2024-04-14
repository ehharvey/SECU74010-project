using Microsoft.EntityFrameworkCore;

namespace StoreWebApp.Models
{
    public class Colour
    {
        public int Id { get; set; }
        public required string ColourName { get; set; }
    }
}