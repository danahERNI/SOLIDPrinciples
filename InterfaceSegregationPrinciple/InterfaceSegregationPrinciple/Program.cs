using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.TimeIn();
            employee.Work();

            Manager manager = new Manager();
            manager.TimeIn();
            manager.Work();
            manager.Manage();

            Admin admin = new Admin();
            admin.TimeIn();
            admin.Work();
            admin.Manage();
            admin.DeleteUser();
        }
    }
}
