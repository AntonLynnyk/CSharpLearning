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
            Console.WriteLine("Enter array of numbers: ");

            string phrase = Console.ReadLine();

            string[] words = phrase.Split(' ');

            int[] numbers = ConvAndAssign(words);

            int[] sortedArray = ExplorMaxValue(numbers);

            PrintSortedArray(sortedArray);

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
        static int[] ExplorMaxValue(int[] values)
        {
            int folder = 0;

            for (int j = 1; j < values.Length - 1; j++)
            {
                for (int i = 0; i < values.Length - 1; i++)
                {
                    if (values[i] > values[i + 1])
                    {
                        folder = values[i];

                        values[i] = values[i + 1];

                        values[i + 1] = folder;
                    }
                }
            }
            return values;
        }
        static void PrintSortedArray(int[] arrayForPrint)
        {
            Console.WriteLine("Sorted array: ");

            for (int i = 0; i < arrayForPrint.Length; i++)
            {
                Console.Write($"{arrayForPrint[i]} ");
            }
        }
    }
}
