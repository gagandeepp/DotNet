class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This is a sample string";
            Console.WriteLine(inputString.WordCount());
        }

    }

    static class ExtensionDemo
    {
        public static int WordCount(this string input)
        {
            return input.Split(new char[] { ' ', '.', '?' },StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }