using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class CSVReportGeneration : IReportGeneration
    {
        public void GenerateReport(Employee employee)
        {
            Console.WriteLine("CSV Report");
        }
    }
}
