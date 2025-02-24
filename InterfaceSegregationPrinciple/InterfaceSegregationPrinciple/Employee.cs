using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Employee : IEmployee
    {
        public void TimeIn()
        {
            Console.WriteLine("Employee time in.");
        }

        public void Work()
        {
            Console.WriteLine("Employee is now working.");
        }
    }

}
