class Program
{
    public delegate void MyEventhandler(int i);
    public event MyEventhandler? valueChanged;

    public static void Main()
    {
        Program obj = new Program();
        obj.valueChanged = (int i) =>
        {
            Console.WriteLine($"Method Invoked {i}");
        };
    }
}