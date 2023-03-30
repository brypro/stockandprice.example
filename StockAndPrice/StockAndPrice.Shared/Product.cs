namespace StockAndPrice.Shared;

public class Product
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }

    virtual public ICollection<ProductStock> Stocks { get; set; }
    virtual public ICollection<ProductPrice> Prices { get; set; }

}
