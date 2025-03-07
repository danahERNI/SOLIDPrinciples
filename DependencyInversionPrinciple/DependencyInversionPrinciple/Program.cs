﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmailService emailService = new EmailService();
            Notification notification = new Notification(emailService);
            notification.PromotionalNotification();
        }
    }
}
