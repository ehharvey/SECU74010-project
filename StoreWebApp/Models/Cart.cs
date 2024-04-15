
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreWebApp.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
    }

    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Product")]
        public Product Product { get; set; }
    }
}