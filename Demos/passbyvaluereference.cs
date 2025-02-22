class Program
{
    public static void PassByValue(int num)
    {
        num = num * 2;
        Console.WriteLine($"Inside method: {num}"); // Output: Inside method: 20
    }

    public static void PassByReference(ref int num)
    {
        num = num * 2;
        Console.WriteLine($"Inside method: {num}"); // Output: Inside method: 20
    }


    public static void Main()
    {
        int a = 10;
        PassByValue(a);
        Console.WriteLine($"Outside method: {a}"); // Output: Outside method: 10

        int a = 10;
        PassByReference(ref a);
        Console.WriteLine($"Outside method: {a}"); // Output: Outside method: 20


    }

}
