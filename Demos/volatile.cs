using System;
using System.Threading;

public class Worker
{
    private volatile bool _shouldStop;

    public void DoWork()
    {
        while (!_shouldStop)
        {
            // Simulate some work
            Console.WriteLine("Working...");
            Thread.Sleep(100);
        }
        Console.WriteLine("Worker thread: terminating gracefully.");
    }

    public void RequestStop()
    {
        _shouldStop = true;
    }
}

public class Program
{
    public static void Main()
    {
        Worker worker = new Worker();
        Thread workerThread = new Thread(worker.DoWork);

        workerThread.Start();

        // Let the worker thread run for a while
        Thread.Sleep(500);

        // Request the worker thread to stop
        worker.RequestStop();

        // Wait for the worker thread to finish
        workerThread.Join();
        Console.WriteLine("Main thread: worker thread has terminated.");
    }
}
