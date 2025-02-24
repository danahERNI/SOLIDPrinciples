using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class User
    {
        protected string _name = "";
        public User(string name)
        {
            _name = name;
        }
        public virtual void LogIn()
        {
            Console.WriteLine($"{_name} is logged in.");
        }
        public virtual void LogOut()
        {
            Console.WriteLine($"{_name} is logged out.");
        }
    }
    public interface IAdmin
    {
        void AccessAdmin();
    }
    public class Admin : User, IAdmin
    {
        public Admin(string name) : base(name) { }
        public void AccessAdmin()
        {
            Console.WriteLine($"{_name} has accessed the admin portal.");
        }
    }
    public class Employee : User
    {
        public Employee(string name) : base(name)
        {
            Console.WriteLine("");
        }
    }

}
