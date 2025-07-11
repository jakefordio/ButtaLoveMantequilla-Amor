using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

public class Slide
{
    [Key]
    public int Id { get; set; }
    public required string ImagePath { get; set; }
    public required string CaptionHeading { get; set; }
    public required string CaptionBody { get; set; }
    public bool IsActive { get; set; } = false;
    // Navigation properties
    public int PageId { get; set; }
    [ForeignKey("PageId")] 
    public ContentPage Page { get; set; } = null!;
}