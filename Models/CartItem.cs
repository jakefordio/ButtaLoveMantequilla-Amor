using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_cart_items")]
public class CartItem
{
    [Key] 
    public int Id { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOn { get; set; }

    // Navigation properties
    public int CartId { get; set; }
    [ForeignKey("CartId")] 
    public ShoppingCart Cart { get; set; } = null!;

    public int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; } = null!;

    // Computed properties
    [NotMapped]
    public decimal TotalPrice => Quantity * Price;
}