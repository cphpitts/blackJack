using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder;
            int groups;
            int result;

            try
            {
                Console.WriteLine("This application will help you divide a group of apples between you and your friends.");
                Console.WriteLine("How many apples do you have?");
                int apples = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nHow groups do you need to divide the apples into?");
                Console.WriteLine("(If no number is submitted, the progream will default to 2)");
                string groupSize = Console.ReadLine();
                if (groupSize != "")

                {
                    groups = Convert.ToInt32(groupSize);
                    result = Split.Splitter(apples, out remainder, groups);
                }
                else
                {
                    result = Split.Splitter(apples, out remainder);
                }
                Console.WriteLine("Each person will get {0} apples", result);
                Console.WriteLine("There will be {0} apples left over", remainder);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.ReadLine();
            }
                
                
            

        }
    }
}
