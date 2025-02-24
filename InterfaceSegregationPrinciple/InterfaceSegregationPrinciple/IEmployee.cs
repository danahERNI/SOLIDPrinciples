using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IEmployee
    {
        void TimeIn();
        void Work();
    }
    public interface IAdmin : IEmployee
    {
        void Manage();
        void DeleteUser();
    }
    public interface IManager : IEmployee
    {
        void Manage();
    }
}
