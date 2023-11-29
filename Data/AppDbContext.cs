using Microsoft.EntityFrameworkCore;

namespace PlatformeService;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }

    public DbSet<Platform> Platforms { get; set; }
}
