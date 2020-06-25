using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nowTime = DateTime.Now;
            Console.WriteLine(nowTime);
            Console.WriteLine("Enter a number:");
            int timeFromNow = Convert.ToInt32(Console.ReadLine());
            DateTime newTime = nowTime.AddHours(timeFromNow);
            Console.WriteLine("In {0} hours it will be {1}", timeFromNow, newTime);
            Console.ReadLine();

        }
    }
}
