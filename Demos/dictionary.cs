using System;
using System.Collections.Generic;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    public static void Main()
    {
        Dictionary<int, Product> productCatalog = new Dictionary<int, Product>
        {
            { 1, new Product { Id = 1, Name = "Laptop", Price = 999.99m } },
            { 2, new Product { Id = 2, Name = "Smartphone", Price = 499.99m } },
            { 3, new Product { Id = 3, Name = "Tablet", Price = 299.99m } }
        };

        // Adding a new product
        productCatalog.Add(4, new Product { Id = 4, Name = "Smartwatch", Price = 199.99m });

        // Accessing a product by its key
        if (productCatalog.TryGetValue(2, out Product product))
        {
            Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }

        // Removing a product
        productCatalog.Remove(3);

        // Iterating through the dictionary
        foreach (var kvp in productCatalog)
        {
            Console.WriteLine($"Key: {kvp.Key}, Product: {kvp.Value.Name}, Price: {kvp.Value.Price}");
        }
    }
}
