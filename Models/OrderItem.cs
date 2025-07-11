using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_order_items")]
public class OrderItem
{
    [Key]
    public int Id { get; set; }

    [MaxLength(200)]
    public string ProductName { get; set; } = string.Empty;

    public required int Quantity { get; set; }
    
    [Column(TypeName = "decimal(10,2)")]
    public required decimal Price { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public required decimal TotalPrice { get; set; }

    // Navigation properties
    public int OrderId { get; set; }
    [ForeignKey("OrderId")]
    public Order Order { get; set; } = null!;

    public int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; } = null!;
}