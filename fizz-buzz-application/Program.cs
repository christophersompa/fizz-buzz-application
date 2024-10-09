using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz_buzz_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");

            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nProcessing...\n");

                int number = 1;

                while (number <= userInput)
                {
                    if (number % 3 == 0 && number % 5 != 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (number % 5 == 0 && number % 3 != 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (number % 3 == 0 && number % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine(number);
                    }
                    number++;
                }

                Console.WriteLine("\nDone.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
