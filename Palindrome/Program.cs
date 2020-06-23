using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("With this app you can determine whether your entered word is polindrome or not");

            Console.WriteLine("Enter you word:");

            string word = Console.ReadLine();

            char[] arrayLetters = word.ToCharArray();

            bool isPolindrome;

            if (arrayLetters.Length == 1)
            {
                isPolindrome = IsPolindrome.DeterminePolindrome(word);
            }
            else
            {
                isPolindrome = IsPolindrome.DeterminePolindrome(arrayLetters);
            }

            if (isPolindrome)
            {
                Console.WriteLine("Your word is a polindrome");
            }
            else
            {
                Console.WriteLine("Your word is not a polindrome");
            }

            Console.ReadLine();
        }
    }
}
