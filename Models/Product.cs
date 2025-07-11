using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_products")]
public class Product
{
    [Key] public int Id { get; set; }

    [MaxLength(200)]
    public required string Name { get; set; } = string.Empty;

    [MaxLength(1000)]
    public string? Description { get; set; }

    [MaxLength(200)]
    public string Slug { get; set; } = string.Empty;

    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal Weight { get; set; }

    public int StockQuantity { get; set; }
    public bool IsActive { get; set; } = true;

    [MaxLength(255)]
    public string? MainImageUrl { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOn { get; set; }

    // Navigation properties
    public int CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public ProductCategory Category { get; set; } = null!;
    public ICollection<ProductImage> ProductImages { get; set; } = [];
    public ICollection<CartItem> CartItems { get; set; } = [];
    public ICollection<OrderItem> OrderItems { get; set; } = [];
}