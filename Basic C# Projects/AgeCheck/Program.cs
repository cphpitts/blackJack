using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime CurrentTime = DateTime.Now;
                int CurrentYear = CurrentTime.Year;

                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 0)
                {
                    throw new ButtonException();
                }
                else if (age == 0)
                {
                    throw new BabyException();
                }
                Console.WriteLine("You were born in {0}. Give or take....", CurrentYear - age);
            }
            catch (ButtonException)
            {
                Console.WriteLine("A negative age? Are you Benjamin Button?");
            }
            catch (BabyException)
            {
                Console.WriteLine("You must be a baby... Babies can't use computers...");
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong happened. Your fault.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
