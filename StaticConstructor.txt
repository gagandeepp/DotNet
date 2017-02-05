 class Program
    {
        Program()
        {
            Console.WriteLine("Program Constructor");
        }
        static void Main(string[] args)
        {
           
            Program obj = new Program();
            ExtensionDemo.SayName = "Gagan";
        }

    }

    static class ExtensionDemo
    {
        public static string SayName;
        static ExtensionDemo()
        {
            Console.WriteLine("Static Class construcor");
        }
    }