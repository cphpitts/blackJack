﻿using System;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Insurotron \n");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI > (yes or no):");
            string dui = Console.ReadLine();
            bool dui_bool = true;
            if (dui == "yes" || dui == "true")
            {
                dui_bool = true;
            }
            else
            {
                dui_bool = false;
            }
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui_bool == false && tickets <= 3);
            Console.Read();
        }
    }
}