///Let's assume that later on we want to extend the system to allow for printing reports in a preview mode. 
// We might then add a method like PreviewReport. 
// This would cause an issue because some of the IReportPrinter implementations (like PDFReportPrinter or ExcelReportPrinter) may not need this functionality. 

// Interface for printing reports
public interface IReportPrinter
{
    void PrintReport(Customer customer);
}

// Interface for previewing reports (only for printers that support preview)
public interface IPreviewable
{
    void PreviewReport(Customer customer);
}

// Interface for exporting reports (only for printers that support export)
public interface IExportable
{
    void ExportReport(Customer customer);
}

// Basic report printer that only prints the report
public class CustomerReportPrinter : IReportPrinter
{
    public void PrintReport(Customer customer)
    {
        Console.WriteLine($"Printing report for customer {customer.Name}");
    }
}

// PDF report printer that supports printing and exporting to PDF
public class PDFReportPrinter : IReportPrinter, IExportable
{
    public void PrintReport(Customer customer)
    {
        Console.WriteLine($"Printing PDF report for customer {customer.Name}");
    }

    public void ExportReport(Customer customer)
    {
        Console.WriteLine($"Exporting PDF report for customer {customer.Name}");
    }
}

// Excel report printer that supports printing and exporting to Excel
public class ExcelReportPrinter : IReportPrinter, IExportable
{
    public void PrintReport(Customer customer)
    {
        Console.WriteLine($"Printing Excel report for customer {customer.Name}");
    }

    public void ExportReport(Customer customer)
    {
        Console.WriteLine($"Exporting Excel report for customer {customer.Name}");
    }
}

// Previewable printer that can generate a preview of the report before printing
public class PreviewReportPrinter : IReportPrinter, IPreviewable
{
    public void PrintReport(Customer customer)
    {
        Console.WriteLine($"Printing preview report for customer {customer.Name}");
    }

    public void PreviewReport(Customer customer)
    {
        Console.WriteLine($"Previewing report for customer {customer.Name}");
    }
}
