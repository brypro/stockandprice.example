namespace StockAndPrice.Shared;

public class ProductStock
{
    public int WarehouseId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int Avaliable { get; set; }
    public int CriticalStock { get; set; }

    public virtual Product Product { get; set; }
    public virtual Warehouse Warehouse { get; set; }

}
