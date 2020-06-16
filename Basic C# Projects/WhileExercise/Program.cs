using System;

namespace WhileExercise
{
    class Program
    {
        static void Main()
        {
            // Set initial value
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i = i + 1;
            } while (i < 10);

            Console.WriteLine("\n");

            while (i > 0)
            {
                Console.WriteLine(i);
                i = i - 2;
            }

            Console.Read();
        }
    }
}
