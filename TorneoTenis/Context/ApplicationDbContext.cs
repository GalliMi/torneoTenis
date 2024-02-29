using Microsoft.EntityFrameworkCore;

namespace TorneoTenis.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Torneo> Torneos { get; set; }
}