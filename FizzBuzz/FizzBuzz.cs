using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private string fizzBuzzGenerator(int i)
        {
            if (i % 3 != 0 && i % 5 != 0)
                return i.ToString();
            if (i % 15 == 0)
                return "FizzBuzz";
            if (i % 3 == 0)
                return "Fizz";
            if (i % 5 == 0)
                return "Buzz";
            return null;
        }

        public string this[int i]
        {
            get { return fizzBuzzGenerator(i+1); }
        }

        public IEnumerable<string> GetFizzBuzz(int upperBound)
        {
            for(int i = 1; i <= upperBound; i++)
            {
                yield return fizzBuzzGenerator(i);
            }
        }
    }
}
