using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("admin");
            Employee Employee = new Employee("member");
            DoSomething(admin);
            DoSomething(Employee);
        }
        public static void DoSomething(User user)
        {
            user.LogIn();
            if (user is IAdmin admin)
            {
                admin.AccessAdmin();
            }
            user.LogOut();
        }

    }
}
