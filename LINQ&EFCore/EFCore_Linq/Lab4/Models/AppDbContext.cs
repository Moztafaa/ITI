using Microsoft.EntityFrameworkCore;

namespace Lab4.Models;

public class AppDbContext : DbContext
{
    private static string ConnectionString =>
        "Server=localhost,1434;Database=Lab4Db;User Id=SA;Password=Mm181120011#;TrustServerCertificate=true;";
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
        // .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<>().HasKey(x => new { , });
    }

    // public override int SaveChanges()
    // {
    //     return base.SaveChanges();
    // }
}
