using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();

            report.GenerateReport("This is some content.");
            report.FormatReport();

            ReportHandling reportHandling = new ReportHandling();

            reportHandling.SaveToFile(report, "report.txt");
            reportHandling.LoadFromFile(report, "report.txt");

            Console.Write(report.Content);


        }
    }
}
