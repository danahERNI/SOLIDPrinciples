using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Admin : IAdmin
    {
        public void DeleteUser()
        {
            Console.WriteLine("Admin used DeleteUser!");
        }

        public void Manage()
        {
            Console.WriteLine("Admin is managing stuff...");
        }

        public void TimeIn()
        {
            Console.WriteLine("Admin time in.");
        }

        public void Work()
        {
            Console.WriteLine("Admin is now working");
        }
    }
}
