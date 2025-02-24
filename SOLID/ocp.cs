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
public interface IReportPrinter
{
    void PrintReport(Customer customer);
}

public class CustomerReportPrinter : IReportPrinter
{
    public void PrintReport(Customer customer)
    {
        Console.WriteLine($"Printing report for customer {customer.Name}");
    }
}

public class PDFReportPrinter : IReportPrinter
{
    public void PrintReport(Customer customer)
    {
        // Logic to generate a PDF report
        Console.WriteLine($"Generating PDF report for customer {customer.Name}");
    }
}

//According to the Open/Closed Principle, we can add this feature without modifying the CustomerReportPrinter class. 
// Instead, we create a new class that implements the IReportPrinter interface.

public class ExcelReportPrinter : IReportPrinter
{
    public void PrintReport(Customer customer)
    {
        // Logic to generate an Excel report
        Console.WriteLine($"Generating Excel report for customer {customer.Name}");
    }
}
