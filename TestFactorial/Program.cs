using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of factorial: ");

            int tryTimes = 10;

            while (tryTimes != 0)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());

                    int factorial = Loop(number);

                    int factorial1 = Recursion(number);

                    if (factorial == factorial1)
                    {
                        Console.WriteLine($"The factorial of {number} is {factorial}");
                    }
                }
                catch (System.FormatException ex)
                {
                    if (tryTimes == 1)
                    {

                        Console.WriteLine("Try next time");
                    }
                    else
                    {
                        Console.WriteLine($"{ex.Message}");

                        Console.WriteLine("You should enter only numbers, not strings!");

                        Console.WriteLine($"You have {tryTimes - 1} more attempts");
                    }
                }
                finally
                {
                    tryTimes--;
                }
            }
        }

        static int Recursion(int value) 
        {
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return value = value * Recursion(value - 1);
            }
        }

        static int Loop(int value) 
        {
            for (int i = value; i > 1; i--)
            {
                value *= (i - 1);
            }

            return value;
        }
    }
}
