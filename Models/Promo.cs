using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models
{
    public class Promo
    {
        [Key]
        public int Id { get; set; }
        public required string Code { get; set; }
        public string? BirthMonthDay { get; set; }
        public string? Season { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? DiscountPercentage { get; set; }
        // Navigation properties
        public int PageId { get; set; }
        [ForeignKey("PageId")] 
        public ContentPage Page { get; set; } = null!;
    }
}