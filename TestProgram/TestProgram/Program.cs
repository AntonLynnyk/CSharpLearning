using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");

            string phrase = Console.ReadLine();

            string[] words = phrase.Split(' ');

            int[] numbers = ConvAndAssign(words);

            int maxValue = ExplorMaxValue(numbers);

            Console.WriteLine($"Max value of array is {maxValue}");

            Console.ReadLine();
        }

        static int[] ConvAndAssign(string[] words)
        {
            int[] numbers = new int[words.Length];

            int number;

            for (int i = 0; i < words.Length; i++)
            {
                number = Int32.Parse(words[i]);

                numbers[i] = number;
            }
            return numbers;
        }

        static int ExplorMaxValue(int[] values)
        {
            int maxValue = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > maxValue)
                {
                    maxValue = values[i];
                }
            }
            return maxValue;
        }
    }
}