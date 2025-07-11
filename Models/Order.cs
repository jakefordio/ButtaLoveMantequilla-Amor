using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_orders")]
public class Order
{
    [Key]
    public int Id { get; set; }
    [Column(TypeName = "decimal(10,2)")] 
    public decimal TaxAmount { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal ShippingAmount { get; set; }

    [Column(TypeName = "decimal(10,2)")] 
    public decimal ProductAmount { get; set; }

    [Required]
    [MaxLength(50)] 
    public string Status { get; set; } = "Pending";

    [MaxLength(100)]
    public string? PaymentMethod { get; set; }

    [MaxLength(200)]
    public string? PaymentTransactionId { get; set; }

    // Billing Street
    [MaxLength(100)]
    public string BillingFirstName { get; set; } = string.Empty;

    [MaxLength(100)]
    public string BillingLastName { get; set; } = string.Empty;

    [MaxLength(200)]
    public string BillingAddress { get; set; } = string.Empty;

    [MaxLength(100)]
    public string BillingCity { get; set; } = string.Empty;

    [MaxLength(10)]
    public string BillingState { get; set; } = string.Empty;

    [MaxLength(20)]
    public string BillingZipCode { get; set; } = string.Empty;

    // Shipping Street
    [MaxLength(100)]
    public string ShippingFirstName { get; set; } = string.Empty;

    [MaxLength(100)] 
    public string ShippingLastName { get; set; } = string.Empty;

    [MaxLength(200)]
    public string ShippingAddress { get; set; } = string.Empty;

    [MaxLength(100)]
    public string ShippingCity { get; set; } = string.Empty;

    [MaxLength(10)]
    public string ShippingState { get; set; } = string.Empty;

    [MaxLength(20)]
    public string ShippingZipCode { get; set; } = string.Empty;

    [MaxLength(1000)] 
    public string? Notes { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOn { get; set; }

    // Navigation properties
    public string UserId { get; set; } = string.Empty;
    [ForeignKey("UserId")] 
    public AppUser User { get; set; } = null!;

    public ICollection<OrderItem> OrderItems { get; set; } = [];
}