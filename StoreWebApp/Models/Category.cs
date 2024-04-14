namespace StoreWebApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string TypeName { get; set; }
        public bool Active { get; set; }
        public bool SocialSharingEnabled { get; set; }
        public bool IsReturnable { get; set; }
        public bool IsExchangeable { get; set; }
        public bool PickupEnabled { get; set; }
        public bool IsTryAndBuyEnabled { get; set; }
    }
}