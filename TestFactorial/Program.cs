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

            int number = int.Parse(Console.ReadLine());

            int factorial = FindingFactorial(number);

            Console.WriteLine($"The factorial of {number} is {factorial}");

            Console.ReadLine();
        }
        static int FindingFactorial(int value)
        {
            if(value == 1)
            {
                return value;
            }
            else
            {
                return value = value * FindingFactorial(value - 1);
            }
        }
    }
}
