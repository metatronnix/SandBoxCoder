
using Newtonsoft.Json.Bson;
using SandboxBoxCoder;
using System.Collections.Generic;

namespace SandBoxTests
{
    public class FizzBuzzTests
    {
        #region FizzBuzzerV1 Tests
        [Fact]
        public void FizzBuzzerV1_Passing_In_1_Generates_Number_As_String()
        {
            Assert.Equal("1", FizzBuzzerV1.Convert(1)); 
        }

        [Fact]
        public void FizzBuzzerV1_Divisible_by_3_produces_fizz()
        {
            Assert.Equal("fizz", FizzBuzzerV1.Convert(3));
        }

        [Fact]
        public void FizzBuzzerV1_Divisible_by_5_produces_buzz()
        {
            Assert.Equal("buzz", FizzBuzzerV1.Convert(5));
        }

        [Fact]
        public void FizzBuzzerV1_Divisible_by_5_and_3_produces_fizzbuzz()
        {
            Assert.Equal("fizzbuzz", FizzBuzzerV1.Convert(15));
        }
        #endregion

        #region FizzBuzzer2 Tests
        [Fact]
        public void FizzBuzzerV2_Passing_in_NonOperand_Returns_Number_As_String()
        {
            Assert.Equal("1", FizzBuzzerV2.Convert(1, 3, 5, "fizz", "buzz"));
        }
        [Fact]
        public void FizzBuzzerV2_Divisible_by_3_Returns_fizz()
        {
            Assert.Equal("fizz", FizzBuzzerV2.Convert(6, 3, 5, "fizz", "buzz"));
        }

        [Fact]
        public void FizzBuzzerV2_Divisible_by_5_Returns_buzz()
        {
            Assert.Equal("buzz", FizzBuzzerV2.Convert(10, 3, 5, "fizz", "buzz"));
        }

        [Fact]
        public void FizzBuzzerV2_Divisible_by_5_and_3_Returns_fizzbuzz()
        {
            Assert.Equal("fizzbuzz", FizzBuzzerV2.Convert(15, 3, 5, "fizz", "buzz"));
        }
        #endregion

        #region FizzBuzzer3 Tests
        [Fact]
        public void FizzBuzzerV3_Passing_In_Non_Operand_Returns_Number_As_String()
        {
            List<(int, string)> operands = new List<(int, string)>
            { 
                (3, "fizz"), 
                (5, "buzz")
            };
            Assert.Equal("1", FizzBuzzerV3.Convert(1, operands));
        }

        [Fact]
        public void FizzBuzzerV3_Divisible_3_Returns_fizz()
        {
            List<(int, string)> operands = new List<(int, string)>
            {
                (3, "fizz"),
                (5, "buzz")
            };
            Assert.Equal("fizz", FizzBuzzerV3.Convert(6, operands));
        }

        [Fact]
        public void FizzBuzzerV3_Divisible_5_Returns_buzz()
        {
            List<(int, string)> operands = new List<(int, string)>
            {
                (3, "fizz"),
                (5, "buzz")
            };
            Assert.Equal("buzz", FizzBuzzerV3.Convert(5, operands));
        }

        [Fact]
        public void FizzBuzzerV3_Divisible_3_and_5_Returns_fizzbuzz()
        {
            List<(int, string)> operands = new List<(int, string)>
            {
                (3, "fizz"),
                (5, "buzz")
            };
            Assert.Equal("fizzbuzz", FizzBuzzerV3.Convert(15, operands));
        }

        [Fact]
        public void FizzBuzzerV3_Divisible_3_5_but_not_10_Returns_fizzbuzz()
        {
            List<(int, string)> operands = new List<(int, string)>
            {
                (3, "fizz"),
                (5, "buzz"),
                (10, "fuzz")
            };
            Assert.Equal("fizzbuzz", FizzBuzzerV3.Convert(15, operands));
        }

        [Fact]
        public void FizzBuzzerV3_Divisible_3_5_10_Returns_fizzbuzzfuzz()
        {
            List<(int, string)> operands = new List<(int, string)>
            {
                (3, "fizz"),
                (5, "buzz"),
                (10, "fuzz")
            };
            Assert.Equal("fizzbuzzfuzz", FizzBuzzerV3.Convert(30, operands));
        }

        #endregion

    }


}