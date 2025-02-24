using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class ReportHandling : Report
    {
        Report report = new Report();
        public string Filename { get; set; }

        public ReportHandling(){}
        public void LoadFromFile(Report report, string filename) 
        { 
            report.Content = File.ReadAllText(filename);
        }
        public void SaveToFile(Report report, string filename)
        {
            File.WriteAllText(filename, report.Content);
        }
    }
}
