using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int displayNum = 4;
            int result;

            Thing.Thingify(num1, out result, displayNum);
            Console.WriteLine("{0} x {1} = {2}", num1, displayNum, result);
            Console.ReadLine();
        }
    }
}
