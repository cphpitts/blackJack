using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string operationName = "Roaring Dragon Thunder";
            //operationName = "Fire Falcon"; //Can't redefine constant

            var target = "Chcoclate Ice Cream";

            Operation operation = new Operation(operationName, target);
            string description = operation.DescribeOp();
            Console.WriteLine(description);
            Console.ReadLine();
        }
    }
}
