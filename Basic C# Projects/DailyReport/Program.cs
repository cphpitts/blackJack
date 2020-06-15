using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            // Student name
            Console.WriteLine("What is your name?");
            string student_Name = Console.ReadLine();
            // Course Name
            Console.WriteLine("What course are you on?");
            string course_Name = Console.ReadLine();
            // Page Number
            Console.WriteLine("What page number?");
            string page_Str = Console.ReadLine();
            int page_Int = Convert.ToInt32(page_Str);
            // Need Help?
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help_Str = Console.ReadLine();
            Boolean help_Bool = Convert.ToBoolean(help_Str);
            // Positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string pos_Experience = Console.ReadLine();
            // Feedback
            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string feeddback = Console.ReadLine();
            // Hours of study
            Console.WriteLine("How many hours did you study today?");
            string hours_Str = Console.ReadLine();
            int hours_Int = Convert.ToInt32(hours_Str);
            // End 
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();

        }
    }
}
