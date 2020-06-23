using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it?");
            string today = Console.ReadLine();
            try
            {
                if (Enum.IsDefined(typeof(Name), today))
                {
                    Console.WriteLine("That's great. Have a nice day.");
                }
                else
                {
                    throw new ApplicationException("Given day not in enum");
                }
                
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
