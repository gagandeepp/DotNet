using System;

public class MyCustomException : Exception
{
    public MyCustomException() { }

    public MyCustomException(string message)
        : base(message) { }

    public MyCustomException(string message, Exception inner)
        : base(message, inner) { }
}
public class Program
{
    public static void Main()
    {
        try {
            ThrowCustomException();
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Caught custom exception: {ex.Message}");
        }
    }

    public static void ThrowCustomException()
    {
        throw new MyCustomException("This is a custom exception message.");
    }
}
