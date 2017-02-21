 class Program
    {
        static void Main(string[] args)
        {
            var retVal = returnTuple();
            Console.WriteLine("Item 1: {0}", retVal.Item1);
            Console.WriteLine("Item 2: {0}", retVal.Item2);
            Console.WriteLine("Item 3: {0}", 
                                        retVal.Item3.ToString("dd/MM/yyyy"));
            Console.Read();
        }
        static Tuple<int, string, DateTime> returnTuple()
        {
            Tuple<int, string, DateTime> tupleObj = 
                        Tuple.Create(1, "Frederico", new DateTime(1975, 3, 24));
            return tupleObj;
        }
    }