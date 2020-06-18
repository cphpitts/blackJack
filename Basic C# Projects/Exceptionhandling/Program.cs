using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int>() { 35, 69, 45, 20, 45, 36 };
        int result;
        bool runProgram = true;

        do
        {
            try
            {
                Console.WriteLine("Enter a whole number");
                int userInt = Convert.ToInt32(Console.ReadLine());
                foreach (int item in intList)
                {
                    result = item / userInt;
                    Console.WriteLine(item + " divided by " + userInt + " is " + result);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number \n" + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. There would be...consequences....\n" + ex.Message);
            }
            finally
            {
                Console.ReadLine();
                bool validAgain = false;
                do
                {
                    Console.WriteLine("Would you like to do it again? (Y/N)");
                    string userAgain = Console.ReadLine().ToLower();
                    if (userAgain == "y")
                    {
                        Console.WriteLine("Yay! Let's go! \n");
                        validAgain = true;
                    }
                    else if (userAgain == "n")
                    {
                        Console.WriteLine("Thanks for playing! \n");
                        validAgain = true;
                        runProgram = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid response");
                    }
                }
                while (!validAgain);
            }
        }
        while (runProgram);
            
    }
}

