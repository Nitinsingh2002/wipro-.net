using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ASSIGNMENT
{
    //story 5
    internal class ReportService
    {
        private readonly IReportFormatter _formatter;

        // Constructor Injection for DIP
        public ReportService (IReportFormatter formatter)
        {
            _formatter = formatter;
        }

        public void ProcessReport()
        {
            string content = "Raw Report Data";
            string formatted = _formatter.Format(content); 
            Console.WriteLine(formatted);
        }

    }
}
