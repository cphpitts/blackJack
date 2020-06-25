using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool continueLoop = true;
            
            while (continueLoop)
            {
                try
                {
                    bool validResponse = false;
                    Console.WriteLine("Enter a new number:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Logger.LogWriter(number);
                    Console.WriteLine("\nThe file currently contains:");
                    string logContent = Logger.LogReader();
                    Console.WriteLine(logContent);
                    while (!validResponse)
                    {
                        Console.WriteLine("\nWould you like to enter a new number?");
                        string response = Console.ReadLine().ToLower();
                        if (response == "y" || response == "yes" || response == "yeah")
                        {
                            validResponse = true;
                        }
                        else if (response == "n" || response == "no" || response == "nope")
                        {
                            validResponse = true;
                            continueLoop = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Response.");
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a whole number.");
                }
            }
        }
    }
}
