using System;


namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            // Set measurement thresholds
            int weight_threshold = 50;
            int size_threshold = 50;

            // Set rate charge
            int rate_Charge = 100;

            Console.WriteLine("Welcome to Planet Expesss. Please Follow the Instructions Below. \n");
            Console.WriteLine("What is the weight of the package? (In pounds)");
            float package_weight = float.Parse(Console.ReadLine());

            // Check package for weight threshold
            if (package_weight > weight_threshold)
            {
                Console.WriteLine("Package is too heavy to be shipped via Planet Express. Have a good day!");
                Console.Read();
            }
            else
            {
                // Get package dimensions
                Console.WriteLine("What is the width of the package? (in inches)");
                float package_width = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the height of the package? (in inches)");
                float package_height = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the length of the package? (in inches)");
                float package_length = float.Parse(Console.ReadLine());
                
                // Check package size threshold
                if (package_width + package_length + package_height > size_threshold)
                {
                    Console.WriteLine("Package is too big to be shipped via Planet Express.");
                    Console.ReadLine();
                }
                else
                {
                    // Get shipping rate
                    decimal ship_Rate = Convert.ToDecimal(package_height * package_length * package_width * package_weight / rate_Charge);
                    string ship_Rate_Str = ship_Rate.ToString("F2");
                    Console.WriteLine("Your Shipping Quote: $" + ship_Rate_Str);
                    Console.Read();
                }

            }
        }
    }
}
