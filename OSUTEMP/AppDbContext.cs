using Microsoft.EntityFrameworkCore;
using OSU.Entities;
using OSUTEMP.Entities;

namespace OSUTEMP
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Trail> Trails { get; set; }
        public DbSet<TrailNote> TrailNotes { get; set; }
    }
}
