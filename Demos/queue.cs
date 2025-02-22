using System;
using System.Collections.Generic;

public class PrintJob
{
    public string DocumentName { get; set; }
    public int Pages { get; set; }
}

public class PrintQueue
{
    private Queue<PrintJob> queue = new Queue<PrintJob>();

    public void AddJob(PrintJob job)
    {
        queue.Enqueue(job);
        Console.WriteLine($"Added job: {job.DocumentName}");
    }

    public void ProcessNextJob()
    {
        if (queue.Count > 0)
        {
            PrintJob job = queue.Dequeue();
            Console.WriteLine($"Processing job: {job.DocumentName}, Pages: {job.Pages}");
        }
        else
        {
            Console.WriteLine("No jobs to process.");
        }
    }

    public void PeekNextJob()
    {
        if (queue.Count > 0)
        {
            PrintJob job = queue.Peek();
            Console.WriteLine($"Next job: {job.DocumentName}, Pages: {job.Pages}");
        }
        else
        {
            Console.WriteLine("No jobs in the queue.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        PrintQueue printQueue = new PrintQueue();
        printQueue.AddJob(new PrintJob { DocumentName = "Report.pdf", Pages = 10 });
        printQueue.AddJob(new PrintJob { DocumentName = "Invoice.docx", Pages = 5 });

        printQueue.PeekNextJob();
        printQueue.ProcessNextJob();
        printQueue.ProcessNextJob();
        printQueue.ProcessNextJob();
    }
}
