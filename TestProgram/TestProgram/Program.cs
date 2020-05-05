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

            int[] numbers = ConvertAndAssign(words);

            int[] sortedArray = ExploreMaxValue(numbers);

            PrintSortedArray(sortedArray);

            Console.ReadLine();
        }
        static int[] ConvertAndAssign(string[] words)
        {
            int[] numbers = new int[words.Length];

            int number;

            int[] error = {0};

            for (int i = 0; i < words.Length; i++)
            {
                if (Int32.TryParse(words[i], out int x))
                {
                    number = Int32.Parse(words[i]);

                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Use only numbers, not strings!");

                    return error;
                }
            }
            return numbers;
        }
        static int[] ExploreMaxValue(int[] values)
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
            if (arrayForPrint.Length == 1)
            {
                Console.WriteLine("Reboot the Program!");
            }
            else
            {
                Console.WriteLine("Sorted array: ");

                for (int i = 0; i < arrayForPrint.Length; i++)
                {
                    Console.Write($"{arrayForPrint[i]} ");
                }
            }
        }
    }
}
