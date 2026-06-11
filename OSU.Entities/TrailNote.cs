using System.ComponentModel.DataAnnotations;
using OSUTEMP.Entities;

namespace OSU.Entities;

public class TrailNote
{
    [Key]
    // Primary Key
    public int NoteId { get; set; }
    // Foreign Key
    public int TrailId { get; set; }
    // Note Content
    public string? NoteText { get; set; }
    // Self Referencing Notes
    public int? ParentNoteId { get; set; }
    public int? ChildNoteId { get; set; }
    // Status
    public string? NoteStatus { get; set; }
    public bool IsPinned { get; set; } = false;
    // Audit Fields
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;    
    // Navigation Property
    public Trail? Trail { get; set; }
}
