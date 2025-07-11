using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_page_content")]
public class PageContent
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255)]
    public required string Title { get; set; }

    [MaxLength(255)]
    public required string Slug { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? SanitizedContent { get; set; } // Clean HTML for display

    [Column(TypeName = "nvarchar(max)")]
    public string? RawContent { get; set; } // Original HTML for editing

    [Column(TypeName = "nvarchar(max)")]
    public string? PlainTextContent { get; set; } // For search indexing

    [MaxLength(500)]
    public string? MetaDescription { get; set; }

    [MaxLength(255)]
    public string? MetaKeywords { get; set; }

    public bool IsPublished { get; set; } = false;
    public bool IsActive { get; set; } = true;

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedOn { get; set; }
    public DateTime? PublishedOn { get; set; }
    

    // Navigation properties
    [MaxLength(450)] // Identity user ID length
    public string? CreatedByUserId { get; set; }
    [ForeignKey("CreatedByUserId")]
    public AppUser? CreatedByUser { get; set; }

    [MaxLength(450)]
    public string? UpdatedByUserId { get; set; }
    [ForeignKey("UpdatedByUserId")]
    public AppUser? UpdatedByUser { get; set; }
}
