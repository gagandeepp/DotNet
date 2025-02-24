using System;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        // Create parameter expressions for two numbers
        ParameterExpression num1 = Expression.Parameter(typeof(int), "num1");
        ParameterExpression num2 = Expression.Parameter(typeof(int), "num2");

        // Create an expression for the addition of num1 and num2
        BinaryExpression addExpression = Expression.Add(num1, num2);

        // Create a lambda expression from the binary expression
        Expression<Func<int, int, int>> lambda = Expression.Lambda<Func<int, int, int>>(addExpression, num1, num2);

        // Compile the expression tree into a delegate
        Func<int, int, int> addFunction = lambda.Compile();

        // Execute the lambda function
        int result = addFunction(5, 10);
        Console.WriteLine($"Result of 5 + 10: {result}");
    }
}
