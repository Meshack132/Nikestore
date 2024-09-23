public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(string category)
    {
        var products = from p in _context.Products
                       select p;

        if (!String.IsNullOrEmpty(category))
        {
            products = products.Where(p => p.Category == category);
        }

        return View(await products.ToListAsync());
    }

    public async Task<IActionResult> Details(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }
}
