using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            newClass number = new newClass();

            Console.WriteLine("Enter a whole number:");

            number.value = Convert.ToInt32(Console.ReadLine());
            number.Divvy(out result);

            Console.WriteLine("{0} divided by 2 is {1}", number.value, result);

            Console.WriteLine("\n Enter another whole number");
            int divisor = Convert.ToInt32(Console.ReadLine());

            number.Divvy(divisor, out result);
            Console.WriteLine("{0} divided by {2} is {1}", number.value, result, divisor);

            int result2 = newClass.Multy(result);
            Console.WriteLine("{0} times 3 is {1}", result, result2);

            Console.ReadLine();
        }
    }
}
