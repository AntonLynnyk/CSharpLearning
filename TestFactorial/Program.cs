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

            try
            {
                int number = int.Parse(Console.ReadLine());

                int factorial = FindingFactorialWithLoop(number);

                Console.WriteLine($"The factorial of {number} is {factorial}");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");

                Console.WriteLine("You should enter only numbers, not strings!");

                int number1 = int.Parse(Console.ReadLine());

                int factorial1 = FindingFactorial(number1);

                Console.WriteLine($"The factorial of {number1} is {factorial1}");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        static int FindingFactorial(int value)
        {
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return value = value * FindingFactorial(value - 1);
            }
        }
        static int FindingFactorialWithLoop(int value)
        {
            for (int i = value; i > 1; i--)
            {
                    value *= (i - 1);
            }
            return value;
        }
    }
}
