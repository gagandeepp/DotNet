  class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"D:\Practice\Testing\Testing\test.txt"))
            {
                string content = File.ReadAllText(@"D:\Practice\Testing\Testing\test.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            File.WriteAllText("test.txt", newContent);
        }
    }