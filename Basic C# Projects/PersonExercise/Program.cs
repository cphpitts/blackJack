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
            Employee<string> employee = new Employee<string>() { firstName = "Sample", lastName = "Student", Id = 6854 };
            employee.SayName();
            employee.Quit();

            IQuittable employee1 = new Employee<string>() { firstName = "Bob", lastName = "Jones", Id = 4582 };
            employee1.Quit();

            // Operator Overload
            Console.WriteLine("Operator Overload:");
            Employee<string> employee2 = new Employee<string>() { firstName = "Barry", lastName = "Alan", Id = 3248 };
            bool sameID = employee == employee2;
            Console.WriteLine("{0} {1} has the same Id as {2} {3}: {4}", employee.firstName, employee.lastName, employee2.firstName, employee2.lastName, sameID);

            // Generic Type Parameter
            Console.WriteLine("Generic Types:");
            Employee<string> strEmployee = new Employee<string>() { firstName = "Alexander" };
            strEmployee.Thing = new List<string>() { "Apples", "Bananas", "Coconuts" };

            Employee<int> intEmployee = new Employee<int>() { firstName = "Steven" };
            intEmployee.Thing = new List<int>() { 1, 3, 5, 8, 9, 5 };

            Console.WriteLine("\n{0}'s things:", strEmployee.firstName);
            foreach (string thing in strEmployee.Thing) {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\n{0}'s things:", intEmployee.firstName);
            foreach (int thing in intEmployee.Thing)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
