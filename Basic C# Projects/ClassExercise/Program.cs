using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int doubleResult = numMachine.DoubleNum(number);
            double halveResult = numMachine.Halve(number);
            string evenOddResult = numMachine.EvenOdd(number);

            Console.WriteLine(number + " times 2 = " + doubleResult);
            Console.WriteLine(number + " divided by 2 = " + halveResult);
            Console.WriteLine(number + " is an " + evenOddResult + " number");
            Console.ReadLine();


        }
    }
}
