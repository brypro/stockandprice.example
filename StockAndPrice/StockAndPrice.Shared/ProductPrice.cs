namespace StockAndPrice.Shared;

public class ProductPrice
{
    public int PriceListId { get; set; }
    public int ProductId { get; set; }
    public int Price { get; set; }

    public virtual Product Product { get; set; }
    public virtual PriceList PriceList { get; set; }
}
