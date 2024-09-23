public class Cart
{
    public List<Product> Products { get; set; } = new List<Product>();
    public decimal TotalAmount => Products.Sum(p => p.Price);
}
