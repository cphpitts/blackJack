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
            Employee<string> employee = new Employee<string>() { FirstName = "Sample", LastName = "Student", Id = 6854 };
            employee.SayName();
            employee.Quit();

            IQuittable employee1 = new Employee<string>() { FirstName = "Bob", LastName = "Jones", Id = 4582 };
            employee1.Quit();

            // Operator Overload
            Console.WriteLine("Operator Overload:");
            Employee<string> employee2 = new Employee<string>() { FirstName = "Barry", LastName = "Alan", Id = 3248 };
            bool sameID = employee == employee2;
            Console.WriteLine("{0} {1} has the same Id as {2} {3}: {4}", employee.FirstName, employee.LastName, employee2.FirstName, employee2.LastName, sameID);

            // Generic Type Parameter
            Console.WriteLine("Generic Types:");
            Employee<string> strEmployee = new Employee<string>() { FirstName = "Alexander" };
            strEmployee.Thing = new List<string>() { "Apples", "Bananas", "Coconuts" };

            Employee<int> intEmployee = new Employee<int>() { FirstName = "Steven" };
            intEmployee.Thing = new List<int>() { 1, 3, 5, 8, 9, 5 };

            Console.WriteLine("\n{0}'s things:", strEmployee.FirstName);
            foreach (string thing in strEmployee.Thing) {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\n{0}'s things:", intEmployee.FirstName);
            foreach (int thing in intEmployee.Thing)
            {
                Console.WriteLine(thing);
            }

            // Lambda
            List < IEmployee > employeeList = new List<IEmployee>();
            Employee<string> emp1 = new Employee<string>() { FirstName = "Joe", LastName = "Montana", Id = 1 };
            employeeList.Add(emp1);
            Employee<string> emp2 = new Employee<string>() { FirstName = "Alan", LastName = "Smith", Id = 2 };
            employeeList.Add(emp2);
            Employee<string> emp3 = new Employee<string>() { FirstName = "Michael", LastName = "Johnson", Id = 3 };
            employeeList.Add(emp3);
            Employee<string> emp4 = new Employee<string>() { FirstName = "Joe", LastName = "Riley", Id = 4 };
            employeeList.Add(emp4);
            Employee<string> emp5 = new Employee<string>() { FirstName = "Sam", LastName = "Bitterman", Id = 5 };
            employeeList.Add(emp5);
            Employee<string> emp6 = new Employee<string>() { FirstName = "Roger", LastName = "Crentist", Id = 6 };
            employeeList.Add(emp6);
            Employee<string> emp7 = new Employee<string>() { FirstName = "Joe", LastName = "Primus", Id = 7 };
            employeeList.Add(emp7);
            Employee<string> emp8 = new Employee<string>() { FirstName = "Mario", LastName = "Luigi", Id = 8 };
            employeeList.Add(emp8);
            Employee<string> emp9 = new Employee<string>() { FirstName = "Jack", LastName = "Donagy", Id = 9 };
            employeeList.Add(emp9);
            Employee<string> emp0 = new Employee<string>() { FirstName = "Neo", LastName = "Reginald", Id = 0 };
            employeeList.Add(emp0);

            Console.WriteLine("\nWrite Joe's with foreach loop");
            List<IEmployee> listJoe = new List<IEmployee>();

            foreach (IEmployee item in employeeList)
            {
                if (item.FirstName == "Joe")
                {
                    listJoe.Add(item);
                }
            }
            foreach (IEmployee item in listJoe){
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            Console.WriteLine("\nWrite Joe's with Lambda expression");
            List<IEmployee> listJoe2 = employeeList.Where(x => x.FirstName == "Joe").ToList();
            foreach (IEmployee item in listJoe2)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            Console.WriteLine("\nEmployees with id greater than 5");
            List<IEmployee> newList = employeeList.Where(x => x.Id > 5).ToList();
            foreach (IEmployee item in newList)
            {
                Console.WriteLine("Employee #{2}: {0} {1}", item.FirstName, item.LastName, item.Id);
            }

            // LAst ReadLine
            Console.ReadLine();
        }
    }
}
