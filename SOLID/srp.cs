public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void SaveToDatabase()
    {
        // Logic to save customer to database
        Console.WriteLine("Saving customer to database.");
    }

    public void PrintCustomerReport()
    {
        // Logic to print customer report
        Console.WriteLine("Printing customer report.");
    }
}


#region  Refactored Approach
public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void SaveToDatabase()
    {
        // Logic to save customer to database
        Console.WriteLine("Saving customer to database.");
    }
}

public class CustomerReportPrinter
{
    public void PrintCustomerReport(Customer customer)
    {
        // Logic to print customer report
        Console.WriteLine($"Printing report for customer {customer.Name}");
    }
}

#endregion