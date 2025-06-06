using System;

namespace SandboxBoxCoder
{
    /* 
     *  "CatMoose"
     *  This version implements the use of parameterized values to decouple the comparative logic (ie, which word is generated) from within the implementation
     *  If "number" is divisible by "x", return stringX
     *  If "number" is divisible by "y", return stringY
     *  If "number" is divisible by both "x" and "y", return stringX+stringY
     */
    public static class FizzBuzzerV2
    {
        public static string Convert(int number, int x, int y, string stringX, string stringY)
        {
            if (number % x == 0 && number % y == 0) return stringX + stringY;
            if (number % x == 0) return stringX;
            if (number % y == 0) return stringY;

            return number.ToString();
        }
    }
}
