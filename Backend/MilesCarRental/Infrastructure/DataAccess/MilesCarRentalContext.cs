using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MilesCarRental.Models;
using System.Configuration;

namespace MilesCarRental.Infrastructure.DataAccess
{
    public class MilesCarRentalContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public MilesCarRentalContext(DbContextOptions<MilesCarRentalContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // **Obtener cadena de conexión de appsettings.json**
                var connectionString = _configuration.GetConnectionString("MilesCarRentalDb");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        //public DbSet<Car> Cars { get; set; }
        //public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Location { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>(entity =>
            //{
            //    entity.ToTable("Cars");

            //    entity.Property(e => e.Id).HasColumnName("Id");

            //    entity.Property(e => e.CategoryId).HasColumnName("CategoryId");

            //    entity.Property(e => e.Description).HasMaxLength(255);

            //    entity.Property(e => e.LicensePlate).HasMaxLength(20);

            //    entity.Property(e => e.Make).HasMaxLength(50);

            //    entity.Property(e => e.Model).HasMaxLength(50);

            //    entity.Property(e => e.PricePerDay).HasColumnType("decimal(18,2)");

            //    entity.HasOne(d => d.Category)
            //        .WithMany(p => p.Cars)
            //        .HasForeignKey(d => d.CategoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull);
            //});

            //modelBuilder.Entity<Category>(entity =>
            //{
            //    entity.ToTable("Categories");

            //    entity.Property(e => e.Id).HasColumnName("Id");

            //    entity.Property(e => e.Name).HasMaxLength(50);
            //});

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Locations");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });
        }
    }

}
