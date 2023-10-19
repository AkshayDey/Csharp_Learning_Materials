using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class PdfReportGeneration : IReportGeneration
    {
        public void GenerateReport(Employee employee)
        {
            Console.WriteLine("Pdf Report");
        }
    }
}
