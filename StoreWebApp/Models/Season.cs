using Microsoft.EntityFrameworkCore;

namespace StoreWebApp.Models
{
    public class Season
    {
        public int Id { get; set; }
        public required string SeasonName { get; set; }
    }
}