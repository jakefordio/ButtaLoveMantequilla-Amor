using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ButtaLove.Models;

[Table("bl_users")]
public class AppUser : IdentityUser
{
    [MaxLength(100)]
    public required string FirstName { get; set; }

    [MaxLength(100)]
    public required string LastName { get; set; }

    [MaxLength(50)] 
    public override required string Email { get; set; }

    [MaxLength(12)]
    public override required string PhoneNumber { get; set; }

    [MaxLength(15)]
    public required string BirthDate { get; set; }

    [MaxLength(200)] 
    public string? Street { get; set; }

    [MaxLength(100)]
    public string? City { get; set; }

    [MaxLength(10)]
    public string? State { get; set; }

    [MaxLength(20)]
    public string? Zip { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedOn { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsOnline { get; set; } = true;

    // Navigation properties
    public ShoppingCart? ShoppingCart { get; set; }
    public ICollection<Order> Orders { get; set; } = [];
}