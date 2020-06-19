using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClass_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { FirstName = "Hal", LastName = "Jordan", Id=2814 };
            employee.SayName();
            Console.WriteLine("Employee Id: {0}", employee.Id);
            Console.ReadLine();


        }
    }
}
