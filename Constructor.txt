class Program
    {
        static void Main(string[] args)
        {
            C objC = new C();
        }

    }

    class A
    {
        internal A()
        {
            Console.WriteLine("Constructor of A");
        }
        ~A()
        {
            Console.WriteLine("Destructor of A");
        }
    }
    class B:A
    {
        internal B()
        {
         Console.WriteLine("Constructor of B");
        }
        ~B()
        {
          Console.WriteLine("Destructor of B");
        }
    }
    class C:B
    {
        internal C()
        {
          Console.WriteLine("Constructor of C");
        }
        ~C()
        {
          Console.WriteLine("Destructor of C");
        }
    }
	
	
	//Construcor of A
	//Construcor of B
	//Construcor of C
	//Destructor of C
	//Destructor of B
	//Destructor of A