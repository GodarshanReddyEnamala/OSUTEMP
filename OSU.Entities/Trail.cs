using OSU.Entities;

namespace OSUTEMP.Entities;

public class Trail
{
    public int Id { get; set; }
    public string? TrailName { get; set; }
    public string? TrailStatus { get; set; }
    public bool IsActive { get; set; } = false;
    public string? TrailDescription { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime LastUpdatedAt {  get; set; }
    public ICollection<TrailNote>? TrailNotes { get; set; }
}
