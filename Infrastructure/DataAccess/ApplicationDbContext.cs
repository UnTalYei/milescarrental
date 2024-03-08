using Domain.Models;
using Microsoft.EntityFrameworkCore;

//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<Car>()
//        .ToTable("Cars");

//    modelBuilder.Entity<Category>()
//        .ToTable("Categories");

//    modelBuilder.Entity<Location>()
//        .ToTable("Locations");

//    // ... Agregar otras configuraciones de entidades
//}

//    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
//    {
//        return await base.SaveChangesAsync(cancellationToken);
//    }
//}

namespace MilesCarRental.Infrastructure.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Location> Locations { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .ToTable("Cars");

        //modelBuilder.Entity<Category>()
        //    .ToTable("Categories");

        //modelBuilder.Entity<Location>()
        //    .ToTable("Locations");

        // ... Agregar otras configuraciones de entidades
    }
}
