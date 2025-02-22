using System;
using System.Text;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string[]> data = new List<string[]>
        {
            new string[] { "Name", "Age", "City" },
            new string[] { "Alice", "30", "New York" },
            new string[] { "Bob", "25", "Los Angeles" },
            new string[] { "Charlie", "35", "Chicago" }
        };

        StringBuilder csvBuilder = new StringBuilder();

        foreach (var row in data)
        {
            csvBuilder.AppendLine(string.Join(",", row));
        }

        string csv = csvBuilder.ToString();
        Console.WriteLine(csv);
    }
}
