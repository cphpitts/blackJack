using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Math-Bot 5000");
            // Multiplication
            Console.WriteLine("Enter a number:");
            double mult_Var =  Convert.ToDouble(Console.ReadLine());
            double mult_Total = Convert.ToDouble(mult_Var * 50);
            Console.WriteLine(mult_Var + " x 50 = " + mult_Total + "\n");

            // Addition
            Console.WriteLine("Enter a number:");
            double add_Var = Convert.ToDouble(Console.ReadLine());
            double add_Total = Convert.ToDouble(add_Var + 25);
            Console.WriteLine(add_Var + " + 25 = " + add_Total + "\n");

            // Division
            Console.WriteLine("Enter a number:");
            double div_Var = Convert.ToDouble(Console.ReadLine());
            double div_Total = Convert.ToDouble(div_Var / 12.5);
            Console.WriteLine(div_Total + " / 12.5 = " + div_Total + "\n");

            // Greater Than 50
            Console.WriteLine("Enter a number");
            double bool_Var = Convert.ToDouble(Console.ReadLine());
            Boolean bool_Result = bool_Var > 50;
            if (bool_Result)
            {
                Console.WriteLine(bool_Var + " is larger than 50 \n");
            }
            else 
            {
                Console.WriteLine(bool_Var + " is not larger than 50 \n");
            }

            // Remainder
            Console.WriteLine("Enter a number:");
            int rem_Var = Convert.ToInt32(Console.ReadLine());
            int rem_Result = rem_Var % 7;
            Console.WriteLine("The remainder of " + rem_Var + "/7 is " + rem_Result + "\n");

            // Final Read
            Console.ReadLine();

        }
    }
}
