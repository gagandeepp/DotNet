using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    class Program
    {
        //Regular Delegate
        public delegate string MyDelegate(int i, int s);
        static int MyFunction(int i, int s)
        {
            return (i + s).ToString();
        }

        static void Main(string[] args)
        {
            // Invoke Func
            Func<int, int> square = x => x * x;
            int result = square(5);  // Pass 5 to the Func
            Console.WriteLine($"The square of 5 is: {result}");

            // Invoke the Action
            Action greet = () => Console.WriteLine("Hello, world!");
            greet();

            // Define a Predicate to check if a number is even
            Predicate<int> isEven = number => number % 2 == 0;
            // Test the Predicate with a number
            bool result = isEven(10);  // Returns true because 10 is even
            Console.WriteLine($"Is 10 even? {result}");
            result = isEven(7);  // Returns false because 7 is odd
            Console.WriteLine($"Is 7 even? {result}");


            // Define a Converter to convert a double to a string
            Converter<double, string> doubleToStringConverter = number => number.ToString("F2");
            // Use the converter
            string result = doubleToStringConverter(123.456);
            Console.WriteLine($"Converted double to string: {result}");


            // Define a Comparison delegate to compare two integers
            Comparison<int> compareIntegers = (x, y) =>
            {
                if (x < y) return -1;
                if (x > y) return 1;
                return 0;
            };
            // Compare two integers using the delegate
            int result = compareIntegers(5, 10);
            Console.WriteLine($"Comparison result: {result}");  // Output: -1

            MyDelegate myDelegate = MyFunction;
            myDelegate(4, 10);

            //Anonymous Delegate
            MyDelegate myDelegate1 = delegate(int i, string s)
            {
                return (i + s).ToString();
            }
            myDelegate1(10, 20);

            //Composable or Chain Delegate

            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            myDelegate2(10, 50);

        }
    }
}
