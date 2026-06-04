using System.ComponentModel.DataAnnotations;

namespace OSU.DataObjects.DTO.TrailModule;

public class AddTrailNoteChildNoteRequest : CreateTrailNoteDto
{
    [Required]
    public int NoteId { get; set; }
}
