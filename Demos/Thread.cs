  class Program
    {
        public static void run()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("In thread " + Thread.CurrentThread.Name + i);
                Thread.Sleep(1000);
            }   
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Starting");
            Thread.CurrentThread.Name = "Main ";

            Thread t1 = new Thread(new ThreadStart(run));
            t1.Name = "Child";
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("In thread " + Thread.CurrentThread.Name + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Main Thread Terminates");
            Console.Read();
        }
    }
	
//Using Lock
	
	public void PrintNumbers()
{
    lock (this)
    {
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(100);
            Console.Write(i + ",");
        }
        Console.WriteLine();
    }
}

//Using Monitor
public void PrintNumbers()
{
    Monitor.Enter(this);
        try
    {
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(100);
            Console.Write(i + ",");
        }
        Console.WriteLine();
    }
    finally
    {
        Monitor.Exit(this);
    }
}