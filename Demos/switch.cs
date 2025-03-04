using System;

class Program
{
    static void Main()
    {
        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }

        #region Pattern Matching
        int number = 15;

        var result = number switch
        {
            <= 10 => "Small",
            > 10 and <= 20 => "Medium",
            > 20 => "Large",
            _ => "Unknown"
        };

        Console.WriteLine(result);  // Output: Medium
        #endregion


        #region Case Guard
        object obj = 15;

        var result = obj switch
        {
            int i when i > 10 => $"Large number: {i}",
            int i when i <= 10 => $"Small number: {i}",
            string s => $"It's a string: {s}",
            _ => "Unknown type"
        };

        Console.WriteLine(result);  // Output: Large number: 15

        #endregion


    }


}