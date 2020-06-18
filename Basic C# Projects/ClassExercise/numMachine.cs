using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class numMachine
    {



        public static int DoubleNum(int num1)
        {
            return num1 * 2;
        }

        public static double Halve(int num1)
        {
            return Convert.ToDouble(num1) / 2;
        }

        public static string EvenOdd(int num1)
        {
            int remainder = num1 % 2;
            if (remainder == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }

     
}
