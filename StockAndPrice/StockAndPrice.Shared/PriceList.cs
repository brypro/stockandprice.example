namespace StockAndPrice.Shared;

public class PriceList
{
    public int Id { get; set; }
    public string PriceListName { get; set; }

    virtual public ICollection<ProductPrice> ProductPrices
    {
        get; set;
    }
}
