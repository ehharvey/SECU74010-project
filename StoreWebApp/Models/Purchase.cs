
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreWebApp.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }

        public required Address Address { get; set; }  

        public required List<int> ProductIds { get; set; }

        public required DateTime PurchaseDate { get; set; } 

        public string AccountId { get; set; }
    }

    public interface IPurchaseRepository
    {
        Purchase GetPurchase(int id);

        Task<Purchase> GetPurchaseAsync(int id);
        void AddPurchase(Purchase purchase);

        Task AddPurchaseAsync(Purchase purchase);

        void DeletePurchase(int id);
    }
}