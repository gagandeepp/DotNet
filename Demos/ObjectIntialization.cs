
    class Program
    {
        static void Main(string[] args)
        {

            Cat cat = new Cat { Age = 10, Name = "Fluffy" };
            var pet = new { Age = 10, Name = "Fluffy" }; //Anonymous Types
            List<Cat> cats = new List<Cat>
                    {
                        new Cat(){ Name = "Sylvester", Age=8 },
                        new Cat(){ Name = "Whiskers", Age=2 },
                        new Cat(){ Name = "Sasha", Age=14 }
                    };

        }

    }

    class Cat
    {
        // Auto-implemented properties.
        public int Age { get; set; }
        public string Name { get; set; }
    }