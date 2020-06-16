using System;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Insurotron \n");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You had had a DUI: (true or false):");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && !dui && tickets <= 3);
            Console.Read();
        }
    }
}
