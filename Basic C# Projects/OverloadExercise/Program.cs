using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            decimal num2 = 15.2m;
            string num3 = "15";

            int result1 = mathBot.calcutron(num1);
            int result2 = mathBot.calcutron(num2);
            int result3 = mathBot.calcutron(num3);

            Console.WriteLine("{0} times 10 = {1}", num1, result1);
            Console.WriteLine("{0} plus 5 = {1}", num2, result2);
            Console.WriteLine("{0} plus 50 = {1}", num3, result3);

            Console.ReadLine();

        }
    }
}
