using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_categories")]
public class ProductCategory
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    public required string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    [MaxLength(200)]
    public required string Slug { get; set; }

    [MaxLength(255)]
    public string? ImageUrl { get; set; }

    public int SortOrder { get; set; } = 0;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOn { get; set; }

    // Navigation properties
    public ICollection<Product> Products { get; set; } = new List<Product>();
}