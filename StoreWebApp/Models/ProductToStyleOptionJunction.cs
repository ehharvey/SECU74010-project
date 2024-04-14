using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace StoreWebApp.Models
{
    public class ProductToStyleOptionJunction
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public required Product Product { get; set; }

        [ForeignKey("StyleOption")]
        public int StyleOptionId { get; set; }

        public required StyleOption StyleOption { get; set; }

        public int Quantity { get; set; }
    }
}