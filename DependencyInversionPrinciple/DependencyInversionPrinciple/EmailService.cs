using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string emailBody)
        {
            Console.WriteLine("Email body contains the following: " + emailBody);
        }
    }
}
