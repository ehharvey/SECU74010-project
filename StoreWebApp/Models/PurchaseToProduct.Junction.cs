
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreWebApp.Models
{
    public class PurchaseToProductJunction
    {
        public int Id { get; set; }

        [ForeignKey("Purchase")]
        public int PurchaseId { get; set; }
        public required Purchase Purchase { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public required Product Product { get; set; }
    }
}