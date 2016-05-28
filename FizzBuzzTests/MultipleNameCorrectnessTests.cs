using FizzBuzzNS;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FizzBuzzTests
{
    [TestFixture]
    class MultipleNameCorrectnessTests
    {
        FizzBuzz fb = new FizzBuzz();
        TestUtils util = new TestUtils();


        /// <summary>
        /// Non Default Multiple-Word Tests
        /// </summary>
        [Test]
        public void NonDefaultWords()
        {
            fb.SetMultipleNamePair(3, "Hire", 5, "MattM");
            IEnumerable<string> results = fb.GetFizzBuzz(20);
            List<string> expected = new List<string>()
            {
                "1",
                "2",
                "Hire",
                "4",
                "MattM",
                "Hire",
                "7",
                "8",
                "Hire",
                "MattM",
                "11",
                "Hire",
                "13",
                "14",
                "HireMattM",
                "16",
                "17",
                "Hire",
                "19",
                "MattM",
            };
            Assert.AreEqual(20, results.Count(), "Expected 20 results");
            CollectionAssert.AreEqual(expected, results, "Returned results are incorrect");
        }

        [Test]
        public void NonDefaultMultiples()
        {
            fb.SetMultipleNamePair(4, "Fizz", 5, "Buzz");
            IEnumerable<string> results = fb.GetFizzBuzz(20);
            List<string> expected = new List<string>()
            {
                "1",
                "2",
                "3",
                "Fizz",
                "Buzz",
                "6",
                "7",
                "Fizz",
                "9",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "Buzz",
                "Fizz",
                "17",
                "18",
                "19",
                "FizzBuzz",
            };
            Assert.AreEqual(20, results.Count(), "Expected 20 results");
            CollectionAssert.AreEqual(expected, results, "Returned results are incorrect");
        }

        [Test]
        public void NonDefaultMultipleAndWords()
        {
            fb.SetMultipleNamePair(2, "Hire", 3, "MattM");
            IEnumerable<string> results = fb.GetFizzBuzz(20);
            List<string> expected = new List<string>()
            {
                "1",
                "Hire",
                "MattM",
                "Hire",
                "5",
                "HireMattM",
                "7",
                "Hire",
                "MattM",
                "Hire",
                "11",
                "HireMattM",
                "13",
                "Hire",
                "MattM",
                "Hire",
                "17",
                "HireMattM",
                "19",
                "Hire",
            };
            Assert.AreEqual(20, results.Count(), "Expected 20 results");
            CollectionAssert.AreEqual(expected, results, "Returned results are incorrect");
        }


        /// <summary>
        /// Quantity of Multiples Tests
        /// </summary>
        [Test]
        public void OneMultiple()
        {
            fb.MultipleNamePair = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(3, "Fizz"),
            };

            IEnumerable<string> results = fb.GetFizzBuzz(20);
            List<string> expected = new List<string>()
            {
                "1",
                "2",
                "Fizz",
                "4",
                "5",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "10",
                "11",
                "Fizz",
                "13",
                "14",
                "Fizz",
                "16",
                "17",
                "Fizz",
                "19",
                "20",
            };
            Assert.AreEqual(20, results.Count(), "Expected 20 results");
            CollectionAssert.AreEqual(expected, results, "Returned results are incorrect");
        }

        [Test]
        public void NoMultiples()
        {
            fb.MultipleNamePair = new List<KeyValuePair<int, string>>()
            {
            };

            IEnumerable<string> results = fb.GetFizzBuzz(20);
            List<string> expected = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
            };
            Assert.AreEqual(20, results.Count(), "Expected 20 results");
            CollectionAssert.AreEqual(expected, results, "Returned results are incorrect");
        }

        [Test]
        public void ThreeMultiples()
        {
            fb.MultipleNamePair = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(3, "Fizz"),
                new KeyValuePair<int, string>(5, "Buzz"),
                new KeyValuePair<int, string>(4, "Foo"),
            };

            IEnumerable<string> results = fb.GetFizzBuzz(20);
            List<string> expected = new List<string>()
            {
                "1",
                "2",
                "Fizz",
                "Foo",
                "Buzz",
                "Fizz",
                "7",
                "Foo",
                "Fizz",
                "Buzz",
                "11",
                "FizzFoo",
                "13",
                "14",
                "FizzBuzz",
                "Foo",
                "17",
                "Fizz",
                "19",
                "BuzzFoo",
            };
            Assert.AreEqual(20, results.Count(), "Expected 20 results");
            CollectionAssert.AreEqual(expected, results, "Returned results are incorrect");
        }


        /// <summary>
        /// Strange Multiples Tests
        /// </summary>
        [Test]
        public void SameMultiples()
        {
            fb.MultipleNamePair = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(3, "Fizz"),
                new KeyValuePair<int, string>(3, "Buzz"),
            };

            IEnumerable<string> results = fb.GetFizzBuzz(20);
            List<string> expected = new List<string>()
            {
                "1",
                "2",
                "FizzBuzz",
                "4",
                "5",
                "FizzBuzz",
                "7",
                "8",
                "FizzBuzz",
                "10",
                "11",
                "FizzBuzz",
                "13",
                "14",
                "FizzBuzz",
                "16",
                "17",
                "FizzBuzz",
                "19",
                "20",
            };
            Assert.AreEqual(20, results.Count(), "Expected 20 results");
            CollectionAssert.AreEqual(expected, results, "Returned results are incorrect");
        }

        [Test]
        public void SameMultiplesSingle()
        {
            fb.SetMultipleNamePair(3, "Fizz", 3, "Buzz");
            int multiple1 = fb.MultipleNamePair[0].Key;
            int multiple2 = fb.MultipleNamePair[1].Key;
            string word1 = fb.MultipleNamePair[0].Value;
            string word2 = fb.MultipleNamePair[1].Value;
          
            Assert.AreEqual(multiple1, multiple2,
                "The test is verifying both multiples are equal");
            Assert.AreEqual(util.RunFizzBuzzSingle(fb, multiple1), word1 + word2);
        }

        [Test]
        public void MultiplesOfMultiples()
        {
            fb.SetMultipleNamePair(3, "Fizz", 3 * 2, "Buzz");
            int multiple1 = fb.MultipleNamePair[0].Key;
            int multiple2 = fb.MultipleNamePair[1].Key;
            string word1 = fb.MultipleNamePair[0].Value;
            string word2 = fb.MultipleNamePair[1].Value;

            Assert.IsTrue(Math.Max(multiple1, multiple2) % Math.Min(multiple1, multiple2) == 0,
                "Test assumes multiple2 will be a multiple of multiple1");
            Assert.AreEqual(util.RunFizzBuzzSingle(fb, multiple1), word1);
            Assert.AreEqual(util.RunFizzBuzzSingle(fb, multiple2), word1 + word2);
        }

        [Test]
        public void Multiple0()
        {
            fb.SetMultipleNamePair(3, "Fizz", 0, "Buzz");

            Assert.Catch(delegate { util.RunFizzBuzzSingle(fb, 5); });
        }

        [Test]
        public void NegativeMultiple()
        {
            fb.SetMultipleNamePair(-3, "Fizz", 5, "Buzz");
            int multiple1 = fb.MultipleNamePair[0].Key;
            int multiple2 = fb.MultipleNamePair[1].Key;
            string word1 = fb.MultipleNamePair[0].Value;
            string word2 = fb.MultipleNamePair[1].Value;

            Assert.AreEqual(util.RunFizzBuzzSingle(fb, Math.Abs(multiple1)), word1);
            Assert.AreEqual(util.RunFizzBuzzSingle(fb, 4), "4");
            Assert.AreEqual(util.RunFizzBuzzSingle(fb, multiple2), word2);
        }

        [Test]
        public void NullMultiples()
        {
            fb.MultipleNamePair = null;

            Assert.Catch(delegate { util.RunFizzBuzzSingle(fb, 5); });
        }
    }
}
