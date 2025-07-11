using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_shopping_carts")]
public class ShoppingCart
{
    [Key]
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOn { get; set; }

    // Navigation properties
    public string UserId { get; set; } = string.Empty;

    [ForeignKey("UserId")]
    public AppUser User { get; set; } = null!;

    public ICollection<CartItem> CartItems { get; set; } = [];

    // Computed properties
    // [NotMapped]
    // public decimal ProductPriceAmount => CartItems.Sum(item => item.Quantity * item.Price);
    //
    // [NotMapped]
    // public int TotalItems => CartItems.Sum(item => item.Quantity);
}