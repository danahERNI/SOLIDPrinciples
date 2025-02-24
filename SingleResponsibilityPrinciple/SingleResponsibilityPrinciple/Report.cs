using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Report
    {
        public string Content { get; set; }
        public Report() { }

        public void GenerateReport(string content)
        {
            Content = content;
        }
        public void FormatReport()
        {
            Content = Content.ToLower();
        }
    }
    
}
