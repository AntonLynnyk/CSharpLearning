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
            Console.WriteLine("With this app you can determine that your entered word is polindrome or not");

            Console.WriteLine("Enter you word:");

            string word = Console.ReadLine();

            char[] arrayLetters = word.ToCharArray();

            int i = IsPolindrome.DeterminePolindrome(arrayLetters);

            if (i == 1)
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
