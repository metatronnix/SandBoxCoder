using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxBoxCoder
{
    /*
    * The quinnissential "fizzbuzz":
    * 1. If divisible by 3, return "fizz"
    * 2. If divisible by 5, return "buzz"
    * 3. If divisible by both, return "fizzbuzz"
    * 4. Otherwise, simply return the number as a string
    */
    public static class FizzBuzzerV1
    {
        public static string Convert(int number)
        {
            if ((number % 3 == 00) && (number % 5 == 0))
                return "fizzbuzz";

            else if (number % 3 == 0)
            {
                return "fizz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }
            else
                return number.ToString();
        }
    }
}
