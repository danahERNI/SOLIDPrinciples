using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Manager : IManager
    {
        public void Manage()
        {
            Console.WriteLine("Manager is managing stuff...");
        }

        public void TimeIn()
        {
            Console.WriteLine("Manager time in.");
        }

        public void Work()
        {
            Console.WriteLine("Manager is now working.");
        }
    }
}
