using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MilesCarRental.Infrastructure.Identity;
using MilesCarRental.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess;
//internal class ApplicationDbContext
//{
//}

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    //public DbSet<TodoList> TodoLists => Set<TodoList>();
    //public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
