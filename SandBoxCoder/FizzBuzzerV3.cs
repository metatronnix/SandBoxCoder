using System.Text;

namespace SandboxBoxCoder
{
    /*
     *  The issue with V2 is that there is no coupling with the numbers and the words generated, save for how they are passed in.
     *  Another issue with V2 is that the current model is limited to 2 numbers. What it you wanted to evaluate three:
     *  Example:
     *   If div by 3, print "Fizz"
     *   If div by 5, print "Buzz"
     *   If div by 10, print "Fuzz"
     *   If div by all three, print "FizzBuzzFuzz".
     *   
     *   To implement such, the signature would have to be expanded by -yet- another modulo operatand and keyword. And so on.
     *   What we want is a function that'll take as many operands and keywords as we throw it, without needing to modify the function
     *   signature itself. 
     *   
     *   One problem is that the original fizzbuzz problem doesn't specify the behavior should it be extended further. The cases that come to mind
     *   are:
     *     1. No modulo == 0. Number is returned as string
     *     2. All operands have a modulo == 0. Return concatenation of all the operand string values.
     *     3. Partial - here's the grey area. We are never told what should happen in the instance of partial match. 
     *          I'm going with the assumption that it should keep as closely to the original requirement as possible, 
     *          i.e. swap out any operands where modulo == 0, and leave out those that do not.
     *                  
     *     Note: This is a brute force - V4 will be optimized.             
     */
    public static class FizzBuzzerV3
    {
        public static string Convert(int number, IList<(int, string)> operands)
        {
            StringBuilder sb = new StringBuilder();

            int matches = operands.Count(n => number % n.Item1 == 0);

            if (matches == 0) // case : No matches
                sb.Append(number.ToString());
            else if (matches == operands.Count) // case: All match - return the full concatenation
                sb.Append(string.Join("", operands.Select(t => t.Item2)));
            else
            {
                foreach ((int, string) operand in operands)
                {
                    if (number % operand.Item1 == 0)
                        sb.Append(operand.Item2.ToString());
                }
            }
            return sb.ToString();
        }

    }
}
