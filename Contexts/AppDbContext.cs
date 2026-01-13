using Microsoft.EntityFrameworkCore;

namespace Bilet16.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<Trainer> Trainers { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}
