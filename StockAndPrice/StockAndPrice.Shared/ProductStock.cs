namespace StockAndPrice.Shared;

public class ProductStock
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int Avaliable { get; set; }
    public int CriticalStock { get; set; }
    public int WarehouseId { get; set; }
    
}
