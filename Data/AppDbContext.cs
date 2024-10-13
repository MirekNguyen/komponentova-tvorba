using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    // Define your DbSets (tables) here
    // public DbSet<YourEntity> YourEntities { get; set; }
}
