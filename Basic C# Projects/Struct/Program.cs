using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 15.25m;

            Console.WriteLine("The number is {0}", number.Amount);
            Console.ReadLine();
        }
    }
}
