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
}
