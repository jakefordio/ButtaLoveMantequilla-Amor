using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_product_images")]
public class ProductImage
{
    [Key] public int Id { get; set; }
    
    [MaxLength(255)]
    public required string ImageUrl { get; set; }

    [MaxLength(200)]
    public string? AltText { get; set; }

    public int SortOrder { get; set; } = 0;
    
    public bool IsMain { get; set; } = false;

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; } = null!;
}