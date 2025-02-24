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
        // Logic to print customer report to the console
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

public class ExcelReportPrinter : IReportPrinter
{
    public void PrintReport(Customer customer)
    {
        // Logic to generate an Excel report
        Console.WriteLine($"Generating Excel report for customer {customer.Name}");
    }
}

public class CustomerService
{
    private readonly IReportPrinter _reportPrinter;

    public CustomerService(IReportPrinter reportPrinter)
    {
        _reportPrinter = reportPrinter;
    }

    public void PrintCustomerReport(Customer customer)
    {
        _reportPrinter.PrintReport(customer);
    }
}

public class Program{
    public static void Main(string[] args)
    {
        Customer customer = new Customer { Name = "John Doe", Email = "john.doe@example.com" };

        // Using Console-based Report Printer
        IReportPrinter reportPrinter1 = new CustomerReportPrinter();
        CustomerService customerService1 = new CustomerService(reportPrinter1);
        customerService1.PrintCustomerReport(customer);

        // Using PDF Report Printer
        IReportPrinter reportPrinter2 = new PDFReportPrinter();
        CustomerService customerService2 = new CustomerService(reportPrinter2);
        customerService2.PrintCustomerReport(customer);

        // Using Excel Report Printer
        IReportPrinter reportPrinter3 = new ExcelReportPrinter();
        CustomerService customerService3 = new CustomerService(reportPrinter3);
        customerService3.PrintCustomerReport(customer);
    }
}