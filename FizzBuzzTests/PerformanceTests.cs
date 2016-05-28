using FizzBuzzNS;
using NUnit.Framework;
using System.Collections.Generic;

namespace FizzBuzzTests
{
    [TestFixture]
    [Ignore("long running test")]
    class PerformanceTests
    {
        FizzBuzz fb = new FizzBuzz();

        [Test]
        public void MaxIntResults()
        {

            IEnumerable<string> results = fb.GetFizzBuzz(int.MaxValue-1);
            foreach (string result in results)
            { }
        }
    }
}
