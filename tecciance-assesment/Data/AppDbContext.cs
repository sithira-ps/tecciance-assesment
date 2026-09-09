using Microsoft.EntityFrameworkCore;
using tecciance_assesment.Models;

namespace tecciance_assesment.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Reservation> Reservations => Set<Reservation>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Laptop", Sku = "ABC1200", OnHand = 20 },
            new Product { Id = 2, Name = "Phone", Sku = "ABC1200", OnHand = 10 }
        );
    }
}