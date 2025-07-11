using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_content_pages")]
public class ContentPage
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255)]
    public required string Title { get; set; }

    [MaxLength(255)]
    public required string Slug { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? Content { get; set; } // Sanitized HTML content

    [Column(TypeName = "nvarchar(max)")]
    public string? RawContent { get; set; } // Optional: original content

    [MaxLength(500)]
    public string? MetaDescription { get; set; }

    [MaxLength(255)]
    public string? MetaKeywords { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOn { get; set; }

    // Navigation properties
    public ICollection<ContentBlock> ContentBlocks { get; set; } = [];
}