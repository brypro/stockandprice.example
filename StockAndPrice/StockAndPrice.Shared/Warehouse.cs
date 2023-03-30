namespace StockAndPrice.Shared;

public class Warehouse
{
    public int Id { get; set; }
    public string WarehouseName { get; set; }
    public string? WarehouseAddress { get; set; }

    virtual public ICollection<ProductStock> Stocks
    {
        get; set;
    }
}
