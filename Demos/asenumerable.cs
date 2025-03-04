using System;
using System.Collections.Generic;
using System.Linq;

public class CustomCollection<T> : List<T>
{
    public IEnumerable<T> Where(Func<T, bool> predicate)
    {
        Console.WriteLine("Custom Where method called.");
        return base.Where(predicate);
    }
}

public class Program
{
    public static void Main()
    {
        CustomCollection<string> fruits = new CustomCollection<string> { "apple", "banana", "cherry" };

        // Using the custom Where method
        var customQuery = fruits.Where(fruit => fruit.Contains("a"));
        Console.WriteLine("Custom Query:");
        foreach (var fruit in customQuery)
        {
            Console.WriteLine(fruit);
        }

        // Using the standard LINQ Where method
        var standardQuery = fruits.AsEnumerable().Where(fruit => fruit.Contains("a"));
        Console.WriteLine("Standard Query:");
        foreach (var fruit in standardQuery)
        {
            Console.WriteLine(fruit);
        }
    }
}
