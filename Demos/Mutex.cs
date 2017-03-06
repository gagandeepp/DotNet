class Program
    {
        private static Mutex mutex = new Mutex();
        private const int numhits = 1;
        private const int numThreads = 4;
        private static void ThreadProcess()
        {
            for (int i = 0; i < numhits; i++)
            {
                UseCsharpcorner();
            }
        }
        private static void UseCsharpcorner()
        {
            mutex.WaitOne();   // Wait until it is safe to enter.
            Console.WriteLine("{0} has entered in the C_sharpcorner.com",
                Thread.CurrentThread.Name);
            // Place code to access non-reentrant resources here.
           Thread.Sleep(500);    // Wait until it is safe to enter.
            Console.WriteLine("{0} is leaving the C_sharpcorner.com\r\n",
                Thread.CurrentThread.Name);
            mutex.ReleaseMutex();    // Release the Mutex.
        }
       static void Main(string[] args)
       {
             for (int i = 0; i < numThreads; i++)
            {
                Thread mycorner = new Thread(new ThreadStart(ThreadProcess));
                mycorner.Name = String.Format("Thread{0}", i + 1);
                mycorner.Start();
            }
            Console.Read();
        }
    }
	
	
	//Output
	// Thread 1 has entered in the C_sharpcorner.com
	// Thread 1 is leaving the C_sharpcorner.com
	
	// Thread 4 has entered in the C_sharpcorner.com
	// Thread 4 is leaving the C_sharpcorner.com
	
	// Thread 2 has entered in the C_sharpcorner.com
	// Thread 2 is leaving the C_sharpcorner.com
	
	// Thread 3 has entered in the C_sharpcorner.com
	// Thread 3 is leaving the C_sharpcorner.com