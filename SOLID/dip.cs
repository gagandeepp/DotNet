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
        Console.WriteLine($"Generating PDF report for customer {customer.Name}");
    }
}

public class ExcelReportPrinter : IReportPrinter
{
    public void PrintReport(Customer customer)
    {
        Console.WriteLine($"Generating Excel report for customer {customer.Name}");
    }
}

public class CustomerService
{
    private readonly IReportPrinter _reportPrinter;

    // The dependency (printer) is injected via constructor
    public CustomerService(IReportPrinter reportPrinter)
    {
        _reportPrinter = reportPrinter;
    }

    public void PrintCustomerReport(Customer customer)
    {
        _reportPrinter.PrintReport(customer);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Customer customer = new Customer { Name = "John Doe", Email = "john.doe@example.com" };

        // Use constructor injection to provide the specific IReportPrinter implementation
        IReportPrinter reportPrinter1 = new CustomerReportPrinter();
        CustomerService customerService1 = new CustomerService(reportPrinter1);
        customerService1.PrintCustomerReport(customer);

        // Using PDF report printer
        IReportPrinter pdfPrinter = new PDFReportPrinter();
        CustomerService customerService2 = new CustomerService(pdfPrinter);
        customerService2.PrintCustomerReport(customer);

        // Using Excel report printer
        IReportPrinter excelPrinter = new ExcelReportPrinter();
        CustomerService customerService3 = new CustomerService(excelPrinter);
        customerService3.PrintCustomerReport(customer);
    }
}
