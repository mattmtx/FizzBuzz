using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Common;
using NUnit.Framework;
using FizzBuzz;

namespace fbTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void bothFizzBuzz()
        {
            FizzBuzz.FizzBuzz fb = new FizzBuzz.FizzBuzz();
            List<string> fbResults = fb.GetFizzBuzz(15);
            Assert.AreEqual(fbResults[14], "FizzBuzz");
        }

        
    }
}
