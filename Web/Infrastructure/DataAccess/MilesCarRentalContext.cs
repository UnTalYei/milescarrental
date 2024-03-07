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
        public DbSet<Car> Cars { get; set; }
        //public DbSet<Categor> Categories { get; set; } // Asumes a Categories table exists
        public DbSet<Location> Locations { get; set; } // Asumes a Locations table exists

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
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50);

                //entity.HasOne(d => d.Category)
                //    .WithMany(p => p.Cars)
                //    .HasForeignKey(d => d.CategoryId)
                //    .OnDelete(DeleteBehavior.ClientSetNull); // Optional behavior based on your needs

                //entity.HasOne(d => d.Location)
                //    .WithMany(p => p.Cars)
                //    .HasForeignKey(d => d.LocationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull); // Optional behavior based on your needs
            });

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
