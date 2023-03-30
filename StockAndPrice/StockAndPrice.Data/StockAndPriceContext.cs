using Microsoft.EntityFrameworkCore;
using StockAndPrice.Shared;

namespace StockAndPrice.Data;

public class StockAndPriceContext : DbContext
{
    public StockAndPriceContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<ProductStock> ProductStocks { get; set; }
    public DbSet<ProductPrice> ProductPrices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ProductPrice>()
            .HasKey(pp => new { pp.ProductId, pp.PriceListId });
        modelBuilder.Entity<ProductStock>()
            .HasKey(pp => new { pp.ProductId, pp.WarehouseId });
    }
}
