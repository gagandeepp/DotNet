using System;

class Program
{
    static void Main()
    {
        int number = 5;
        Console.WriteLine("Before ref method: " + number);
        ModifyRef(ref number);  // Passing by reference
        Console.WriteLine("After ref method: " + number);


        int number;
        bool result = TryParseInt("42", out number);
        if (result)
        {
            Console.WriteLine("Parsed successfully: " + number);
        }
        else
        {
            Console.WriteLine("Parsing failed.");
        }

        int number = 10;
        PrintIn(in number);  // Passing by reference, but read-only

    }

    static void ModifyRef(ref int x)
    {
        x = x * 2;  // Modifies the original value
    }

    static bool TryParseInt(string input, out int x)
    {
        return int.TryParse(input, out x);  // Assigns a value to 'x'
    }

    static void PrintIn(in int x)
    {
        Console.WriteLine("Value passed as in: " + x);
        // x = 20; // This would cause a compile-time error because 'x' is read-only
    }
}