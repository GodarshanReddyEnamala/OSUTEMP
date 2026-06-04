
using Microsoft.EntityFrameworkCore;

using OSU.Common.Helpers;
using OSU.DataObjects.DTO.TrailModule;
using OSU.Entities;

using OSUTEMP.Entities;
using Microsoft.AspNetCore.Mvc;

namespace OSUTEMP.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TrailController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    public const int MaxRetries = 3;

    private readonly static string s_connectionString = "sudfhuhzdh";

    /// <summary>
    /// xgfhdhfdhd
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("CreateTrail")]
    public async Task<IActionResult> CreateTrail([FromBody] CreateTrailRequest request)
    {
        #region
        const string name = "asjdh";
        Console.WriteLine(name);

        #endregion

        if (request == null)
        {
            return BadRequest(new
            {
                Success = false,
                Message = "Trail data is required"
            });
        }

        Console.WriteLine(s_connectionString);
        var trail = new Trail
        {
            TrailName = request.TrailName,
            TrailStatus = request.TrailStatus,
            TrailDescription = request.TrailDescription,
            CreatedAtUtc = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow
        };

        await _context.Trails.AddAsync(trail);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            Success = true,
            Message = "Trail created successfully",
            Data = trail
        });
    }

    /// <summary>
    /// Add note to trail While creating.
    /// </summary>
    /// <param name="dto">sDFsdf</param>
    /// <returns>fgd</returns>
    [HttpPost]
    [Route("AddNote")]
    public async Task<IActionResult> AddNote([FromBody] CreateTrailNoteDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        // Check if Trail exists
        var trailExists = await _context.Trails.AnyAsync(t => t.Id == dto.TrailId);
        if (!trailExists)
            return NotFound($"Trail with ID {dto.TrailId} not found.");

        var note = new TrailNote
        {
            TrailId = dto.TrailId,
            NoteText = dto.Title,
            NoteStatus = "UnResolved",
            CreatedAtUtc = DateTime.UtcNow
        };

        _context.TrailNotes.Add(note);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetNoteById), new { id = note.NoteId }, note);
    }

    /// <summary>
    /// Add chaild note for Existing Note.
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [Route("AddedChildNote")]
    public async Task<IActionResult> AddChildNote([FromBody] AddTrailNoteChildNoteRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var noteIdExist = await _context.Trails.AnyAsync(t => t.Id == request.NoteId);
        if (!noteIdExist)
        {
            return BadRequest(ResponseBuilder.Failure($"NoteId {request.NoteId}"));
        }

        var note = new TrailNote
        {
            TrailId = request.TrailId,
            NoteText = request.Title,
            NoteStatus = "UnResolved",
            CreatedAtUtc = DateTime.UtcNow
        };
        _context.TrailNotes.Add(note);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetNoteById), new { id = note.NoteId }, ResponseBuilder.Success(note));
    }

    /// <summary>
    /// Get Note By NoteId
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetNoteById(int id)
    {
        var age = 25;
        if (age > 10)
        {
            Console.WriteLine();
        }

        Console.WriteLine(age);
        var note = await _context.TrailNotes.FindAsync(id);
        if (note == null)
        {
            return NotFound();
        }

        return Ok(note);
    }
}
