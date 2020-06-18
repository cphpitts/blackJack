using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //// Part 1        
        //string[] heroDesc = new string[]
        //{
        //    "is brave",
        //    "fights for justice",
        //    "stands up for what's right",
        //    "is a true hero"
        //};

        //Console.WriteLine("Enter your favorite superhero");
        //string favHero = Console.ReadLine();

        //for (int i = 0; i < heroDesc.Length; i++)
        //{
        //    Console.WriteLine(favHero + " " + heroDesc[i]);
        //}


        //// Part 2 and 3
        //Console.WriteLine("\n");
        //Console.WriteLine("Enter a number between 1 and 10");
        //int num = Convert.ToInt32(Console.ReadLine());
        //while (num > 0)
        //{
        //    Console.WriteLine(num);
        //    num--;
        //}

        ////Part 4
        //List<int> numList = new List<int>() { 15, 35, 20, 85, 74, 35, 60, 50 };
        //foreach (int num in numList)
        //{
        //    if (num < 50)
        //    {
        //        Console.WriteLine(num + " is less than 50");
        //    }
        //}

        //// Part 5
        //List<int> tempList = new List<int>() { 58, 68, 90, 85, 72, 99, 65, 78 };
        //foreach (int temp in tempList)
        //{
        //    if (temp <= 65)
        //    {
        //        Console.WriteLine("It's " + temp + " degrees. It's chilly");
        //    }
        //    else
        //    {
        //        Console.WriteLine("It's " + temp + " degree. It's warm.");
        //    }
        //}

        //// Part 6 & 7 & 8
        //List<string> fruitList = new List<string> { "apple", "banana", "orange", "pear", "kiwi", "orange"};
        //Console.WriteLine("Enter a fruit:");
        //string fruit = Console.ReadLine();
        //int index = 0;
        //bool match = false;

        //foreach (string item in fruitList)
        //{
        //    if (item == fruit)
        //    {
        //        Console.WriteLine(fruit + " in at index " + index);
        //        match = true;
        //        break;
        //    }
        //    index++;
        //}
        //if (!match)
        //{
        //    Console.WriteLine("No match found");
        //}

        //// Part 9 & 10
        //List<string> fruitList = new List<string>() { "red", "green", "blue", "red", "orange", "green", "purple", "red", "yellow" };
        //List<int> indexList = new List<int>();
        //Console.WriteLine("Enter a color:");
        //string color = Console.ReadLine();
        //int index = 0;
        //bool match = false;

        //foreach (string item in fruitList)
        //{
        //    if (item == color)
        //    {
        //        indexList.Add(index);
        //        match = true;
        //    }
        //    index++;
        //}
        //if (match)
        //{
        //    foreach (int item in indexList)
        //    {
        //        Console.WriteLine(color + " can be found at index " + item);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine(color + " is not in the list");
        //}

        // Part 11
        List<string> heroList = new List<string>()
        {
            "Captain America",
            "Black Widow",
            "Spider-Man",
            "Iron Man",
            "Black Widow",
            "Captain America",
            "Captain Marvel",
            "Hawkeye",
            "Ant-Man",
            "Black Widow",
            "Spider-Man",
            "Ant-Man"
        };
  
        
        for ( int i = 0; i < heroList.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (heroList[j] == heroList[i])
                {
                    Console.WriteLine(heroList[j] + " has been in the list earlier");
                    break;
                }
            }

        }



        Console.ReadLine();
    }
}
