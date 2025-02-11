using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ASSIGNMENT
{
    //story 3 Implement Liskov Substitution Principle (LSP)
    public abstract class Report
    {
        public abstract string GetContent();
    }


    public class PdfReport : Report
    {
        public override string GetContent()
        {
            return "PDF Report Content";
        }
    }

    public class ExcelReport : Report
    {
        public override string GetContent()
        {
            return "Excel Report Content";
        }
    }

    public class ReportPrinter
    {
        public void PrintReport(Report report)
        {
            Console.WriteLine(report.GetContent());
        }
    }
}
