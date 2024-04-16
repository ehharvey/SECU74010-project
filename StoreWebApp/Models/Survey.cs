
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreWebApp.Models 
{
    public class Survey
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        public Brand Brand { get; set; }


        public bool IsSatisfied { get; set; }
    }

    public interface ISurveyRepository
    {
        Task AddSurveyAsync(Survey s);
    }
}