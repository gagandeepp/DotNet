public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    // RowVersion column for concurrency control
    [Timestamp]
    public byte[] RowVersion { get; set; }
}

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the RowVersion column
        modelBuilder.Entity<Product>()
            .Property(p => p.RowVersion)
            .IsRowVersion();  // Tells EF Core to treat it as a concurrency token
    }
}

public async Task UpdateProductAsync(int productId, string newName, decimal newPrice)
{
    using (var context = new ApplicationDbContext())
    {
        var product = await context.Products
            .FirstOrDefaultAsync(p => p.ProductId == productId);

        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        // Simulate changes to the product
        product.Name = newName;
        product.Price = newPrice;

        try
        {
            // Attempt to save the changes
            await context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            // Handle concurrency conflict
            var entry = ex.Entries.Single();
            var databaseValues = entry.GetDatabaseValues();

            if (databaseValues == null)
            {
                Console.WriteLine("The product has been deleted by another user.");
            }
            else
            {
                Console.WriteLine("The product was modified by another user.");
                var dbProduct = (Product)databaseValues.ToObject();

                // Handle the conflict by asking the user to decide what to do
                Console.WriteLine($"Database Name: {dbProduct.Name}, Database Price: {dbProduct.Price}");

                // Example of resolving the conflict (could be done through user input):
                // Overwrite with database value or keep the user's changes
                product.Name = dbProduct.Name;  // Keep the latest data from the database
                product.Price = dbProduct.Price;

                // Retry saving after resolving the conflict
                await context.SaveChangesAsync();
            }
        }
    }
}
