public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public string Category { get; set; } // "Sneakers" or "T-shirts"
}

public class Order
{
    public int Id { get; set; }
    public List<Product> Products { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; }
}
