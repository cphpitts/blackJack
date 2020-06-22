using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student", Id = 6854 };
            employee.SayName();
            employee.Quit();

            IQuittable employee1 = new Employee() { firstName = "Bob", lastName = "Jones", Id = 4582 };
            employee1.Quit();

            Employee employee2 = new Employee() { firstName = "Barry", lastName = "Alan", Id = 3248 };

            bool sameID = employee == employee2;

            Console.WriteLine("{0} {1} has the same Id as {2} {3}: {4}", employee.firstName, employee.lastName, employee2.firstName, employee2.lastName, sameID);
            
            Console.ReadLine();
        }
    }
}
