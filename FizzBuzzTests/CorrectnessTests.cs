using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Common;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestFixture]
    public class CorrectnessTests
    {
        [Test]
        public void bothFizzBuzz()
        {
            FizzBuzz.FizzBuzz fb = new FizzBuzz.FizzBuzz();
            int i = 15;
            Assert.AreEqual(fb[i-1], "FizzBuzz");
        }
    }
}
