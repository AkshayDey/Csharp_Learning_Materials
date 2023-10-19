using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{


    /// <summary>
    /// Bad Design Code for Open-Closed Principle
    /// </summary>
    public class ReportGeneration
    {
        public string ReportType { get; }
        public ReportGeneration(string reportType)
        {
            ReportType = reportType;
        }
        public void GenerateReport(Employee employee)
        {
            if (ReportType == "CRS")
            {

            }
            if (ReportType == "PDF")
            {

            }

        }
    }
}
