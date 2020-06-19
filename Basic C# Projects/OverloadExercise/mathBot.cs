using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadExercise
{
    class mathBot
    {
        public static int calcutron(int number)
        {
            int result = number * 10;
            return result;
        }

        public static int calcutron(decimal number)
        {
            int result = Convert.ToInt32(number) + 5;
            return result;
        }

        public static int calcutron(string number)
        {
            int result = Convert.ToInt32(number) + 50;
            return result;
        }
        

    }
}
