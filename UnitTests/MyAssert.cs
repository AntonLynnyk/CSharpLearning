using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class MyAssert
    {
        /// <summary>
        /// Checks the condition and throws the exeption if condition is false.
        /// </summary>
        /// <param name="condition">Condition that is expected to be false</param>
        public static void IsTrue (bool condition)
        {
            if (condition != true)
            {
                throw new Exception("Assert is false but expected true");
            }
        }
        
        /// <summary>
        /// Checks the condition and throws the exeption if condition is true.
        /// </summary>
        /// <param name="condition">Condition that is expected to be true</param>
        public static void IsFalse (bool condition)
        {
            if (condition != false)
            {
                throw new Exception("Assert is true but expected false");
            }
        }
    }
}
