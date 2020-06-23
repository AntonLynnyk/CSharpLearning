using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class IsPolindrome
    {
        public static bool DeterminePolindrome(string s)
        {
            if (s == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool DeterminePolindrome(char[] arrayLetters)
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
