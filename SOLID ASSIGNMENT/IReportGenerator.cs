using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ASSIGNMENT
{
    //story Interface Segregation Principle (ISP)
    internal interface IReportGenerator
    {
        string Generate();
    }

    //segragating interface
    public interface IReportSaver
    {
        void Save(string content);
    }

    //implementing interface
    public class PdfReportGenerator : IReportGenerator
    {
        public string Generate()
        {
            return "Generated PDF Report";
        }
    }

    //implemnting interface

    public class FileReportSaver : IReportSaver
    {
        public void Save(string content)
        {
            File.WriteAllText("report.txt", content);
        }
    }

}
