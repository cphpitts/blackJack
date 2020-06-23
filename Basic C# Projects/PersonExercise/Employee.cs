using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExercise
{
    public class Employee<T> : Person, IQuittable, IEmployee
    {
        public int Id { get; set; }
        public List<T> Thing { get; set; }

        public override void SayName()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("{0} {1} has left the building", FirstName, LastName);
        }

        public static bool operator== (Employee<T> employee1, Employee<T> employee2)
        {
            return (employee1.Id == employee2.Id);
        }
        public static bool operator!= (Employee<T> employee1, Employee<T> employee2)
        {
            return (employee1.Id == employee2.Id);
        }
    }
}
