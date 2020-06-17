using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] moodArray = { "I'm sorry we let you down", "I hope you give us another shot", "We'll do better next time", "That's great to hear", "AMAZING!" };
        bool validRating = false;
        int rating = 0;
        do
        {
            Console.WriteLine("How would you rate our service today?");
            rating = Convert.ToInt32(Console.ReadLine()) - 1;
            if (rating < 0 || rating > 4)
            {
                Console.WriteLine("Invalid Rating. Please Try Again.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(moodArray[rating] + "\n");
                Console.ReadLine();
                validRating = true;
            }
        }
        while (!validRating);

        int[] bowlArray = { 4, 8, 9, 7, 5, 12 };
        bool validBowl = false;
        int bowlNum = 0;
        do
        {
            Console.WriteLine("There are 6 bowls in front of you filled with cherries. Which one do you want?");
            bowlNum = Convert.ToInt32(Console.ReadLine()) - 1;
            if (bowlNum < 0 || bowlNum > 5)
            {
                Console.WriteLine("Invalid bowl selection. Please try again");
                Console.ReadLine();
            }
            else if (bowlNum == 5)
            {
                Console.WriteLine("Great pick! You scored " + bowlArray[bowlNum] + " cherries!");
                Console.ReadLine();
                validBowl = true;
            }
            else
            {
                Console.WriteLine("You get " + bowlArray[bowlNum] + " cherries.");
                Console.ReadLine();
                validBowl = true;
            }
        }
        while (!validBowl);


        List<string> hotdogs = new List<string>
        {
            "Guess you're not hungry",
            "Here you go!",
            "You must be hungry",
            "Does your mother feed you?",
            "Slow down there!"
        };


        bool validDogs = false;
        int hdNum = 0;
        do
        {
            Console.WriteLine("How many hot dogs do you want?");
            hdNum = Convert.ToInt32(Console.ReadLine());
            if (hdNum < 0 )
            {
                Console.WriteLine("That doesn't many any sense.");
                Console.ReadLine();
            }
            else if (hdNum > 4)
            {
                Console.WriteLine("Very funny. For real, though....");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(hotdogs[hdNum]);
                Console.ReadLine();
                validDogs = true;
            }
        }
        while (!validDogs);






        //// Arrays
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray2 = new int[] { 5, 2, 10, 455, 6578 };

        //int[] numArray3 = { 1, 2, 5, 9, 20, 85456 };

        //// Lists
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);

        //List<string> strList = new List<string>();
        //strList.Add("Hello");
        //strList.Add("There");
        //strList.Add("!");

        //Console.WriteLine(intList[0]);
        //Console.Read();

    }
}

