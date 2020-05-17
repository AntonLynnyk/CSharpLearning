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

                    int factorialLoop = GetFactorialLoop(number);

                    int factorialRecursion = GetFactorialRecunsion(number);

                    if (factorialLoop == factorialRecursion)
                    {
                        Console.WriteLine($"The factorial of {number} is {factorialLoop}");
                    }
                    else
                    {
                        Console.WriteLine("Something get wrong, please try again");
                    }
                }
                catch (System.FormatException ex)
                {
                    if (tryTimes == 1)
                    {

                        Console.WriteLine("You have only one try left!");
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

        static int GetFactorialRecunsion(int value) 
        {
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return value = value * GetFactorialRecunsion(value - 1);
            }
        }

        static int GetFactorialLoop(int value) 
        {
            for (int i = value; i > 1; i--)
            {
                value *= (i - 1);
            }

            return value;
        }
    }
}
