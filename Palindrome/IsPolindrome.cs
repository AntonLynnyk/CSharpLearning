using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class IsPolindrome
    {
        public static bool DeterminePolindrome(string enteredString)
        {
            if (enteredString == "")
            {
                return false;
            }
            else if (enteredString.Contains(" "))
            {
                string stringWhithoutSpaces = enteredString.Replace(" ", String.Empty);

                return DeterminePolindrome(stringWhithoutSpaces.ToCharArray());
            }
            else
            {
                return DeterminePolindrome(enteredString.ToCharArray());
            }
        }

        private static bool DeterminePolindrome(char[] arrayLetters)
        {
            for (int i = arrayLetters.Length - 1, k = 0; i >= 0; i--, k++)
            {
                if (arrayLetters[k] != arrayLetters[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
