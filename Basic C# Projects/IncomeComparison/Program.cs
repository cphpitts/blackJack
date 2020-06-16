using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program \n");

            // Person 1
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate?");
            decimal hour_Rate_1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week?");
            decimal hour_Worked_1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n");

            // Person 2
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate?");
            decimal hour_Rate_2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("HourlS Worked Per Week?");
            decimal hour_Worked_2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n");

            // Totals
            decimal total_1 = hour_Rate_1 * hour_Worked_1;
            decimal total_2 = hour_Rate_2 * hour_Worked_2;
            Console.WriteLine("Person 1 Salary: $" + total_1);
            Console.WriteLine("Person 2 Salary: $" + total_2);
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(Convert.ToString(total_1 > total_2));
            Console.Read();


        }
    }
}
