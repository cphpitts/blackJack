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
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            employee.Quit();

            IQuittable employee1 = new Employee() { firstName = "Bob", lastName = "Jones" };
            employee1.Quit();

            Console.ReadLine();
        }
    }
}
