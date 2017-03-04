
    interface Demo
    {
        void SayTest();
        void SayHi();
    }
    class Program:Demo
    {
        //Implicit --> Need to Specify Public
        public void SayTest()
        {
            Console.WriteLine("SayTest of Interface");
        }
        //Explicit
        void Demo.SayHi()
        {
            Console.WriteLine("SayHi Of Interface");
        }
        void SayHello()
        {
            Console.WriteLine("SayHello of class");
        }
        static void Main()
        {
            Program obj = new Program();
            //obj.SayHello();
            Demo obj1 = obj;
            obj.SayHello();
            obj1.SayTest();
            obj1.SayHi();
        }

    }