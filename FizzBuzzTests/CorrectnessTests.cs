using FizzBuzzNS;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTests
{
    [TestFixture]
    public class DefaultsCorrectnessTests
    {
        FizzBuzz fb = new FizzBuzz();
        int multiple1, multiple2;
        string word1, word2;
        TestUtils util = new TestUtils();

        [SetUp]
        public void Init()
        {
            multiple1 = fb.MultipleNamePair[0].Key;
            multiple2 = fb.MultipleNamePair[1].Key;
            word1 = fb.MultipleNamePair[0].Value;
            word2 = fb.MultipleNamePair[1].Value;
        }

        /// <summary>
        /// Correctness accessing SINGLE element of the results
        /// </summary>
        [Test]
        public void BothMultiples()
        {
            util.TestFizzBuzzSingle(fb, multiple1 * multiple2, word1 + word2);
        }

        [Test]
        public void OnlyMultiple1Exact()
        {
            Assert.IsFalse(Math.Max(multiple1, multiple2) % Math.Min(multiple1, multiple2) == 0,
                "Test assumes multiple1 will not be a multiple of multiple2");
            util.TestFizzBuzzSingle(fb, multiple1, word1);
        }

        [Test]
        public void OnlyMultiple1()
        {
            Assert.IsFalse(Math.Max(multiple1, multiple2) % Math.Min(multiple1, multiple2) == 0,
                "Test assumes multiple1 will not be a multiple of multiple2");
            util.TestFizzBuzzSingle(fb, multiple1 * 2, word1);
        }

        [Test]
        public void OnlyMultiple2Exact()
        {
            Assert.IsFalse(Math.Max(multiple1, multiple2) % Math.Min(multiple1, multiple2) == 0,
                "Test assumes multiple1 will not be a multiple of multiple2");
            util.TestFizzBuzzSingle(fb, multiple2, word2);
        }

        [Test]
        public void OnlyMultiple2()
        {
            Assert.IsFalse(Math.Max(multiple1, multiple2) % Math.Min(multiple1, multiple2) == 0, 
                "Test assumes multiple1 will not be a multiple of multiple2");
            util.TestFizzBuzzSingle(fb, multiple2 * 2, word2);
        }


        /// <summary>
        /// Correctness of Entire list of results
        /// </summary>
        [Test]
        public void AllResultsTo20()
        { 
            IEnumerable<string> results = fb.GetFizzBuzz(20);
            List<string> expected = new List<string>()
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz",
                "16",
                "17",
                "Fizz",
                "19",
                "Buzz",
            };
            Assert.AreEqual(20, results.Count(), "Expected 20 results");
            CollectionAssert.AreEqual(expected, results, "Returned results are incorrect");
        }

    }
}
