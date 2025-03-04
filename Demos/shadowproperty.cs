public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                          .UseSqlServer("your_connection_string")
                          .Options;

        using (var context = new ApplicationDbContext(options))
        {
            // Create a new product with shadow properties
            var product = new Product
            {
                Name = "Laptop",
                Price = 999.99m
            };

            // Set shadow property 'CreatedBy'
            context.Entry(product).Property("CreatedBy").CurrentValue = "admin";

            // Set shadow property 'IsDeleted'
            context.Entry(product).Property("IsDeleted").CurrentValue = false;

            context.Products.Add(product);
            await context.SaveChangesAsync();
        }
    }
}

public async Task GetProductWithShadowProperties(int productId)
{
    using (var context = new ApplicationDbContext())
    {
        var product = await context.Products
            .Where(p => p.ProductId == productId)
            .Select(p => new
            {
                Product = p,
                CreatedBy = EF.Property<string>(p, "CreatedBy"),
                IsDeleted = EF.Property<bool>(p, "IsDeleted")
            })
            .FirstOrDefaultAsync();

        Console.WriteLine($"Product: {product.Product.Name}, Created By: {product.CreatedBy}, Is Deleted: {product.IsDeleted}");
    }
}
