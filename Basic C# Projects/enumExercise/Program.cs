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
                    Name date;
                    Enum.TryParse<Name>(today, out date);
                    Console.WriteLine("That's great. Have a nice day.");
                    int dayofWeek = ((int)date) + 1;
                    Console.WriteLine("Its the {0} day of the week.", dayofWeek);
                    Console.WriteLine("");
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
