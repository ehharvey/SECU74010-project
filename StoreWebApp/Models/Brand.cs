using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace StoreWebApp.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public required string BrandName { get; set; }
    }
}