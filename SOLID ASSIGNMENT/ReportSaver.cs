using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ASSIGNMENT
{
    internal class ReportSaver
    {
        //story 1 following srp
        public void SaveReport(string content, string filePath)
        {
            File.WriteAllText(filePath, content);
        }
    }
}
