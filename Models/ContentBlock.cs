using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtaLove.Models;

[Table("bl_content_blocks")]
public class ContentBlock
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public required string BlockType { get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(max)")]
    public string Content { get; set; } = "{}"; // This will store sanitized HTML or JSON

    [Column(TypeName = "nvarchar(max)")]
    public string? RawContent { get; set; } // Optional: store original unsanitized content

    public int SortOrder { get; set; } = 0;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOn { get; set; }

    // Navigation properties
    public int PageId { get; set; }

    [ForeignKey("PageId")] 
    public ContentPage Page { get; set; } = null!;
}