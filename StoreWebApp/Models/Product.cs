using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StoreWebApp.Models
{
    public class Product
    {
        
        [Key]
        public int Id { get; set; }

        public int Price { get; set; }

        public int? DiscountedPrice { get; set; }

        public required string ProductDisplayName { get; set; }

        public int CatalogAddDate { get; set; } // Unix epoch time

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        public required Brand Brand { get; set; }

        [ForeignKey("AgeGroup")]
        public int? AgeGroupId { get; set; }

        public AgeGroup? AgeGroup { get; set; }

        [ForeignKey("Gender")]
        public int GenderId { get; set; }

        public required Gender Gender { get; set; }

        [ForeignKey("BaseColour")]
        public int? BaseColourId { get; set; }

        public Colour? BaseColour { get; set; }

        [ForeignKey("Colour1")]
        public int? Colour1Id { get; set; }

        public Colour? Colour1 { get; set; }

        [ForeignKey("Colour2")]
        public int? Colour2Id { get; set; }

        public Colour? Colour2 { get; set; }

        [ForeignKey("Season")]
        public int? SeasonId { get; set; }

        public Season? Season { get; set; }

        public int? Year { get; set; }

        [ForeignKey("Usage")]
        public int? UsageId { get; set; }

        public Usage? Usage { get; set; }

        [ForeignKey("MasterCategory")]
        public int? MasterCategoryId { get; set; }

        public Category? MasterCategory { get; set; }

        [ForeignKey("SubCategory")]
        public int? SubCategoryId { get; set; }

        public Category? SubCategory { get; set; }

        [ForeignKey("ArticleType")]
        public int? ArticleTypeId { get; set; }

        public Category? ArticleType { get; set; }

        public required string ImageUrl { get; set; }
    }

    public interface IProductRepository
    {

        List<Product> GetProducts(int page_number, int page_size = 20);

        Task<List<Product>> GetProductsAsync(int page_number, int page_size = 20, string? Filter=null);

        Product? GetProductById(int id);

        Task<Product?> GetProductByIdAsync(int id);

        int GetNumberOfProducts(string? Filter=null);

        Task<int> GetNumberOfProductsAsync(string? Filter=null);
    }
}