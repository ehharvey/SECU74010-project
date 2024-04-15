
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreWebApp.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }
        
        public Cart Cart { get; set; }
        
    }
}