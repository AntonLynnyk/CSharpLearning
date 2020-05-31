using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! You have to put in your decimal which you want to transform to binary.");

            int tryTimes = 10;

            while (tryTimes != 0) // to change something
            {
                try
                {
                    int valueToCalculate = int.Parse(Console.ReadLine());

                    int[] binary = ConvertDecimalToBinary(valueToCalculate);

                    PrintBinary(binary, valueToCalculate);
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


                Console.ReadLine();
        }

        private static void PrintBinary(int[] binary, int value)
        {
            Console.Write($"Your decimal number in binary is: ");
            foreach (var zeroOrOne in binary)
            {
                Console.Write(zeroOrOne);
            }
            Console.WriteLine("");
        }

        static int[] ConvertDecimalToBinary(int value)
        {
            List<int> binary = new List<int>();

            int remainder;

            while (value > 0)
            {
                remainder = value % 2;

                value = value / 2;

                binary.Add(remainder);
            }
            
            int[] reversed = GetRevense(binary);

            return reversed;
            
        }

        static int[] GetRevense(List<int> binary)
        {
            int[] array = new int [binary.Count];

            for (int i = binary.Count - 1; i >= 0; i--)
            {
                array[binary.Count - i - 1] = binary[i];
            }

            return array;
        }
    }
}
