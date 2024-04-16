using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using StoreWebApp.Models;

namespace StoreWebApp.Components
{
    public class MyDbContext : DbContext, ILoginRepository, IProductRepository, IZipCodeRepository, IPurchaseRepository
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Login> Logins { get; set; }
        

        
        public DbSet<Brand> Brands { get; set; }
        public DbSet<AgeGroup> AgeGroups { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Colour> Colours { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductToStyleOptionJunction> ProductToStyleOptionJunctions { get; set; }

        public DbSet<Season> Seasons { get; set; }

        public DbSet<StyleOption> StyleOptions { get; set; }

        public DbSet<Usage> Usages { get; set; }

        public DbSet<ZipCodeData> ZipCodes { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public void AddLogin(Login login)
        {
            throw new NotImplementedException();
        }

        public Task AddLoginAsync(Login login)
        {
            throw new NotImplementedException();
        }

        public void AddPurchase(Purchase purchase)
        {
            Purchases.Add(purchase);
            SaveChanges();
        }

        public Task AddPurchaseAsync(Purchase purchase)
        {
            Purchases.Add(purchase);
            return SaveChangesAsync();
        }

        public void DeletePurchase(int id)
        {
            Purchases.Remove(GetPurchase(id));
            SaveChanges();
        }

        public string? GetLoggedInUser() => Logins.FirstOrDefault()?.Email;

        public Task<string?> GetLoggedInUserAsync()
        {
            return Task.FromResult(GetLoggedInUser());
        }

        public Login GetLogin(string email)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfProducts()
        {
            return Products.Count();
        }

        public Task<int> GetNumberOfProductsAsync()
        {
            return Products.CountAsync();
        }

        public Product? GetProductById(int id)
        {
            return Products.Find(id);
        }

        public Task<Product?> GetProductByIdAsync(int id)
        {
            return Products.FindAsync(id).AsTask();
        }

        public List<Product> GetProducts(int page_number, int page_size = 20)
        {
            return Products.Skip(page_number * page_size).Take(page_size).ToList();
        }

        public Task<List<Product>> GetProductsAsync(int page_number, int page_size = 20)
        {
            return Products.Skip(page_number * page_size).Take(page_size).ToListAsync();
        }

        public Purchase GetPurchase(int id)
        {
            return Purchases.Find(id);
        }

        public Task<Purchase> GetPurchaseAsync(int id)
        {
            return Purchases.FindAsync(id).AsTask();
        }

        public ZipCodeData GetZipCode(string zipCode)
        {
            return ZipCodes.Find(zipCode);
        }

        public async Task<ZipCodeData> GetZipCodeAsync(string zipCode)
        {
            return await ZipCodes.FindAsync(zipCode).AsTask();
        }

        public async Task<List<ZipCodeData>> GetZipCodesAsync(string zipCode, int results = 20)
        {
            return await ZipCodes.Where(z => z.ZipCode.StartsWith(zipCode)).ToListAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
            modelBuilder.Entity<Models.Login>().HasKey(i => i.Id);
            modelBuilder.Entity<Models.Login>().HasData(
                new Models.Login(-1, "test@example.com", "password")
            );

            modelBuilder.Entity<Category>().HasKey(i => i.Id);

            modelBuilder.Entity<Product>().HasOne<Category>(p => p.MasterCategory).WithMany().HasForeignKey(p => p.MasterCategoryId);
            modelBuilder.Entity<Product>().HasOne<Category>(p => p.SubCategory).WithMany().HasForeignKey(p => p.SubCategoryId);
            modelBuilder.Entity<Product>().HasOne<Category>(p => p.ArticleType).WithMany().HasForeignKey(p => p.ArticleTypeId);

            modelBuilder.Entity<Brand>().HasKey(i => i.Id);

            modelBuilder.Entity<Product>().HasOne<Brand>(p => p.Brand).WithMany().HasForeignKey(p => p.BrandId);

            modelBuilder.Entity<AgeGroup>().HasKey(i => i.Id);

            modelBuilder.Entity<Product>().HasOne<AgeGroup>(p => p.AgeGroup).WithMany().HasForeignKey(p => p.AgeGroupId);

            modelBuilder.Entity<Colour>().HasKey(i => i.Id);

            modelBuilder.Entity<Product>().HasOne<Colour>(p => p.BaseColour).WithMany().HasForeignKey(p => p.BaseColourId);
            modelBuilder.Entity<Product>().HasOne<Colour>(p => p.Colour1).WithMany().HasForeignKey(p => p.Colour1Id);
            modelBuilder.Entity<Product>().HasOne<Colour>(p => p.Colour2).WithMany().HasForeignKey(p => p.Colour2Id);

            modelBuilder.Entity<Gender>().HasKey(i => i.Id);

            modelBuilder.Entity<Product>().HasOne<Gender>(p => p.Gender).WithMany().HasForeignKey(p => p.GenderId);

            modelBuilder.Entity<Season>().HasKey(i => i.Id);

            modelBuilder.Entity<Product>().HasOne<Season>(p => p.Season).WithMany().HasForeignKey(p => p.SeasonId);

            modelBuilder.Entity<Usage>().HasKey(i => i.Id);

            modelBuilder.Entity<Product>().HasOne<Usage>(p => p.Usage).WithMany().HasForeignKey(p => p.UsageId);

            modelBuilder.Entity<StyleOption>().HasKey(i => i.Id);            

            modelBuilder.Entity<Product>().HasKey(i => i.Id);

            modelBuilder.Entity<ProductToStyleOptionJunction>().HasKey(i => i.Id);

            
            modelBuilder.Entity<ProductToStyleOptionJunction>().HasOne<Product>(p => p.Product).WithMany().HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<ProductToStyleOptionJunction>().HasOne<StyleOption>(p => p.StyleOption).WithMany().HasForeignKey(p => p.StyleOptionId);

            modelBuilder.Entity<ZipCodeData>().HasKey(i => i.ZipCode);
            modelBuilder.Entity<Address>().HasKey(i => i.Id);
            modelBuilder.Entity<Address>().HasOne<ZipCodeData>(a => a.ZipCodeData).WithMany().HasForeignKey(a => a.ZipCode);

            modelBuilder.Entity<Purchase>().HasKey(i => i.Id);
            modelBuilder.Entity<Purchase>().HasOne<Address>(p => p.Address).WithMany().HasForeignKey(p => p.AddressId);

            modelBuilder.Entity<PurchaseToProductJunction>().HasKey(i => i.Id);
            modelBuilder.Entity<PurchaseToProductJunction>().HasOne<Purchase>(p => p.Purchase).WithMany().HasForeignKey(p => p.PurchaseId);
            modelBuilder.Entity<PurchaseToProductJunction>().HasOne<Product>(p => p.Product).WithMany().HasForeignKey(p => p.ProductId);
        }
    }
}