public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();
    services.Configure<StripeSettings>(Configuration.GetSection("Stripe"));
}
