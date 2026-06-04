using System.ComponentModel.DataAnnotations;

namespace OSU.DataObjects.DTO.TrailModule;

public class CreateTrailNoteDto : CommonNoteRequestObject
{
    [Required]
    public int TrailId { get; set; }
}
