using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class IsPolindrome
    {
        public static int DeterminePolindrome(char[] arrayLetters)
        {
            int k = 0;

            for (int i = arrayLetters.Length - 1; i >= 0; i--)
            {
                if (arrayLetters[k] == arrayLetters[i])
                {
                    k++;
                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }

        

            
    }
}
