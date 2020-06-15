using System;
using System.Diagnostics.Eventing.Reader;

namespace AcmeAccounting
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter User Name: ");
            string login = Console.ReadLine();
            Console.WriteLine("Welcome, " + login + " to Acme");
            Console.WriteLine("Remember, we're \"accounting\" on you");
            Console.Read();
        }
    }
}
