using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ASSIGNMENT
{
    //story 2  Open/Closed Principle (OCP)
    internal interface IReportFormatter
    {
        string Format(string content);
    }


    //pdf formatting
    public class PdfReportFormatter : IReportFormatter
    {
        public string Format(string content)
        {
             return "pdf format: " + content;
        }
    }

    // Excel Formatting
    public class ExcelReportFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return "Excel format :" + content;
        }
    }
}
