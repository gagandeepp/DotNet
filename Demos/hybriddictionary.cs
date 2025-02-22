using System;
using System.Collections.Specialized;

public class Inventory
{
    private HybridDictionary products = new HybridDictionary();

    public void AddProduct(string name, double price)
    {
        products.Add(name, price);
    }

    public void RemoveProduct(string name)
    {
        products.Remove(name);
    }

    public void DisplayProducts()
    {
        foreach (DictionaryEntry entry in products)
        {
            Console.WriteLine($"Product: {entry.Key}, Price: {entry.Value}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Inventory inventory = new Inventory();
        inventory.AddProduct("Milk", 1.99);
        inventory.AddProduct("Bread", 2.49);
        inventory.AddProduct("Eggs", 3.19);

        Console.WriteLine("Current Inventory:");
        inventory.DisplayProducts();

        inventory.RemoveProduct("Bread");

        Console.WriteLine("After removal:");
        inventory.DisplayProducts();
    }
}
