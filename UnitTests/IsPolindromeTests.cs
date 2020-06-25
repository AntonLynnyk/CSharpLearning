using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class IsPolindromeTests
    {
        [TestMethod]
        public void DeterminePolindrome_CorrectPolindrome_ReturnsTrue() 
        {
            // SetUp 
            string correctPolindrome = "123454321";

            // Action
            bool result = IsPolindrome.DeterminePolindrome(correctPolindrome);

            // Check
            MyAssert.IsTrue(result);
        }

        [TestMethod]
        public void DeterminePolindrome_IncorrectPolindrome_ReturnsFalse() 
        {
            // SetUp 
            string incorrectPolindrome = "123451234";

            // Action
            bool result = IsPolindrome.DeterminePolindrome(incorrectPolindrome);

            // Check
            MyAssert.IsFalse(result);
        }

        [TestMethod]
        public void DeterminePolindrome_EmptyString_ReturnsFalse() 
        {
            string emptyString = "";

            bool result = IsPolindrome.DeterminePolindrome(emptyString);

            MyAssert.IsFalse(result);
        }

        [TestMethod]
        public void DeterminePolindrome_SingleCharacter_ReturnsTrue() 
        {
            string singleCharacter = "1";

            bool result = IsPolindrome.DeterminePolindrome(singleCharacter);

            MyAssert.IsTrue(result);
        }
        [TestMethod]

        public void DeterminePolindrome_StringIncludesSpaces_ReturnsFalse() 
        {
            string includesSpaces = "ab c d cba";

            bool result = IsPolindrome.DeterminePolindrome(includesSpaces);

            MyAssert.IsTrue(result);
            
        }

        [TestMethod]
        public void DeterminePolindrome_CorrectPolindromeIncludesSymbols_ReturnsTrue() 
        {
            string includesSymbols = "@#$%%$#@";

            bool result = IsPolindrome.DeterminePolindrome(includesSymbols);

            MyAssert.IsTrue(result);
        }
    }
}
