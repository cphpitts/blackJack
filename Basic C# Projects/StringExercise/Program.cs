using System;
using System.Text;

namespace StringExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Mad Libs \n");
            Console.WriteLine("Enter an animal.");
            string animal = Console.ReadLine();
            Console.WriteLine("Enter an adjective");
            string adj = Console.ReadLine();
            Console.WriteLine("Enter a food");
            string food = Console.ReadLine();
            string sentence = "The " + adj + " " + animal + " ate a large bowl of " + food + ".";
            Console.WriteLine(sentence + "\n");

            Console.WriteLine("What are you hungry for?");
            Console.WriteLine(food.ToUpper() + "\n");

            StringBuilder sb = new StringBuilder();
            sb.Append("In a hole in the ground there lived a hobbit. ");
            sb.Append("Not a nasty, dirty, wet hole, filled with the ends of worms and an oozy smell, nor yet a dry, bare, sandy hole with nothing in it to sit down on or to eat; ");
            sb.Append("it was a hobbit-hole, and that means comfort.");
            Console.WriteLine(sb);
            Console.Read();
        }

    }
}
