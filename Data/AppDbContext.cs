using Microsoft.EntityFrameworkCore;
using komponentova_tvorba.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    // Define your DbSets (tables) here
    // public DbSet<YourEntity> YourEntities { get; set; }
}
