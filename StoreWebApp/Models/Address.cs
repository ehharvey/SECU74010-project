
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreWebApp.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ZipCodeData")]
        public string ZipCode { get; set; }
        public required ZipCodeData ZipCodeData { get; set; }

        public required string Street { get; set; }

        public required string Phone { get; set; }

        public required string Email { get; set; }
    }
}