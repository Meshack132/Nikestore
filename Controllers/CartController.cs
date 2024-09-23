public class CartController : Controller
{
    private readonly ApplicationDbContext _context;
    private Cart _cart;

    public CartController(ApplicationDbContext context)
    {
        _context = context;
        _cart = new Cart();
    }

    public IActionResult Index()
    {
        return View(_cart);
    }

    public async Task<IActionResult> Add(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
        {
            _cart.Products.Add(product);
        }

        return RedirectToAction("Index");
    }

    public IActionResult Checkout()
    {
        return View(_cart);
    }

    public IActionResult PayWithStripe()
    {
        var options = new ChargeCreateOptions
        {
            Amount = (long)(_cart.TotalAmount * 100), // Amount in cents
            Currency = "usd",
            Description = "Nike Store Purchase",
            Source = Request.Form["stripeToken"],
        };

        var service = new ChargeService();
        Charge charge = service.Create(options);

        // Save the order to the database

        return View("Success");
    }


}
