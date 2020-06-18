using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 45, 96, 85, 58 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();


        //string[] names = { "Jesse", "James", "Bob", "Eric" };
        //for(int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);   
        //}
        //Console.ReadLine();

        List<int> testScores2 = new List<int>() { 98, 78, 85, 67, 85, 90, 78, 83, 91 };
        List<int> passingScores = new List<int> ();

        foreach (int score in testScores2)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        foreach (int score in passingScores)
        {
            Console.WriteLine(score);
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
}
