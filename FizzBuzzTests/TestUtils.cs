using FizzBuzzNS;
using NUnit.Framework;

namespace FizzBuzzTests
{
    class TestUtils
    {
        public string RunFizzBuzzSingle(FizzBuzz fb, int number)
        {
            return fb[number - 1];
        }

        public void TestFizzBuzzSingle(FizzBuzz fb, int number, string expectedOutput)
        {
            string outputLine = RunFizzBuzzSingle(fb, number);

            Assert.AreEqual(expectedOutput, outputLine);
        }
    }
}
