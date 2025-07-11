using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

public class Testimonial
{
    [Key] 
    public int Id { get; set; }
    public string CustomerName { get; set; } = "Customer Name";
    public DateTime CreatedOn { get; set; }
    public string QuoteBody { get; set; } = "Caption Body here, roll tide.";
    public bool IsActive { get; set; } = false;
    // Navigation properties
    public int PageId { get; set; }
    [ForeignKey("PageId")] 
    public ContentPage Page { get; set; } = null!;
}