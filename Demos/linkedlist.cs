using System;
using System.Collections.Generic;

public class BrowserHistory
{
    private LinkedList<string> history;
    private LinkedList<string> current;

    public BrowserHistory()
    {
        history = new LinkedList<string>();
    }

    public void Visit(string url)
    {
        if (current != null)
        {
            // Remove all forward history
            while (current.Next != null)
            {
                history.RemoveLast();
            }
        }
        history.AddLast(url);
        current = history.Last;
        Console.WriteLine($"Visited: {url}");
    }

    public void Back()
    {
        if (current?.Previous != null)
        {
            current = current.Previous;
            Console.WriteLine($"Back to: {current.Value}");
        }
        else
        {
            Console.WriteLine("No previous page.");
        }
    }

    public void Forward()
    {
        if (current?.Next != null)
        {
            current = current.Next;
            Console.WriteLine($"Forward to: {current.Value}");
        }
        else
        {
            Console.WriteLine("No next page.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        BrowserHistory browserHistory = new BrowserHistory();
        browserHistory.Visit("https://example.com");
        browserHistory.Visit("https://example.com/about");
        browserHistory.Visit("https://example.com/contact");

        browserHistory.Back();
        browserHistory.Back();
        browserHistory.Forward();
    }
}
