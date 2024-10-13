using Microsoft.EntityFrameworkCore;
using komponentova_tvorba.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    // Define your DbSets (tables) here
    // public DbSet<YourEntity> YourEntities { get; set; }
}
