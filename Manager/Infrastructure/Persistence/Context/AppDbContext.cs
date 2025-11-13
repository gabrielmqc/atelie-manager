using Manager.Adapters.Outbound.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manager.Infrastructure.Persistence.Context;

public class AppDbContext : DbContext
{
    public DbSet<ClotheEntity> Clothes { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClotheEntity>().ToTable("Clothes");
        base.OnModelCreating(modelBuilder);
    }
}