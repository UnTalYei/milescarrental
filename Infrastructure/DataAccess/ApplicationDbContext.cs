﻿using System.Reflection;
using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MilesCarRental.Application.Common.Interfaces;
using MilesCarRental.Infrastructure.Identity;

namespace MilesCarRental.Infrastructure.Models;

public class ApplicationDbContext : DbContext
//public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext

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

        modelBuilder.Entity<Location>()
            .ToTable("Locations");

        //base.OnModelCreating(modelBuilder);
        //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // ... Agregar otras configuraciones de entidades
    }
}
