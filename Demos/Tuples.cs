 class Program
    {
        static void Main(string[] args)
        {
            var tuple = Tuple.Create(1, "hello", true);
            Console.WriteLine(tuple.Item1); // 1
            Console.WriteLine(tuple.Item2); // hello
            Console.WriteLine(tuple.Item3); // true

            var valueTuple = (1, "hello", true);
            Console.WriteLine(valueTuple.Item1); // 1
            Console.WriteLine(valueTuple.Item2); // hello
            Console.WriteLine(valueTuple.Item3); // true

            var namedTuple = (Id: 1, Message: "hello", IsValid: true);
            Console.WriteLine(namedTuple.Id);       // 1
            Console.WriteLine(namedTuple.Message);  // hello
            Console.WriteLine(namedTuple.IsValid);  // true

            // Tuple Deconstruction
            var (id, message, isValid) = (1, "hello", true);
            Console.WriteLine(id);       // 1
            Console.WriteLine(message);  // hello
            Console.WriteLine(isValid);  // true

    }