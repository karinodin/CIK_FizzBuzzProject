using System.Runtime.InteropServices;
using FizzBuzz.Program;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzUnitTests
    {
        private FizzBuzzLogic fizzBuzz;
        
        [TestInitialize]
        public void FizzBuzzFixture()
        {
            fizzBuzz = new FizzBuzzLogic();
        }

        [TestMethod]
        public void If_Divisible_By_3_Then_Fizz_Is_Returned()
        {
            var input = 3;
            var expected = "Fizz";

            var actual = fizzBuzz.FizzBuzzWordGenerator(input);

            Assert.AreEqual(expected, actual);
        }
 
        [TestMethod]
        public void If_Divisible_By_5_Then_Buzz_Is_Returned()
        {
            var input = 5;
            var expected = "Buzz";

            var actual = fizzBuzz.FizzBuzzWordGenerator(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_Divisible_By_3_And_5_Then_FizzBuzz_Is_Returned()
        {
            var input = 15;
            var expected = "FizzBuzz";

            var actual = fizzBuzz.FizzBuzzWordGenerator(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_Not_Divisible_By_3_or_5_Then_The_Input_Is_Returned()
        {
            var input = 19;
            var expected = "19";

            var actual = fizzBuzz.FizzBuzzWordGenerator(input);

            Assert.AreEqual(expected, actual);
        }
    }
}