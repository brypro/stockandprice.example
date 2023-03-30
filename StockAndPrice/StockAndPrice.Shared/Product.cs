namespace StockAndPrice.Shared;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Code { get; set; }

    public virtual ICollection<ProductStock>? Stocks { get; set; }
    public virtual ProductPrice? Price { get; set; }

}
