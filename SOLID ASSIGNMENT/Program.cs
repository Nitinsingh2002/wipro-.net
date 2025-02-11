using SOLID_ASSIGNMENT;

internal class Program
{
    private static void Main(string[] args)
    {
        IReportFormatter formatter = new PdfReportFormatter(); // Change to ExcelReportFormatter if needed
        ReportService reportService = new ReportService(formatter); // Inject dependency
        reportService.ProcessReport();
    }
}