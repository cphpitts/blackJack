using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    class Thing
    {
        public static void Thingify(int number, out int result, int displayNum)
        {
            result = number * displayNum;
            Console.WriteLine("Second integer: {0}", displayNum);
        }
        
    }
}
