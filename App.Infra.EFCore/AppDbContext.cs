using App.Core.AdminEntity;
using App.Core.CustomerEntity;
using App.Infra.EFCore.Configs;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.EFCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Admin> Admins { get; set; }
}
