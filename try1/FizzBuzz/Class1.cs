using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private List<string> _FizzBuzzRes;
  
        private void GenFizzBuzz(int upperBound)
        {
            for (int i = 1; i <= upperBound; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                    _FizzBuzzRes.Add(i.ToString());
                else
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        _FizzBuzzRes.Add("FizzBuzz");
                    }
                    else
                    {
                        if (i % 3 == 0)
                            _FizzBuzzRes.Add("Fizz");
                        if (i % 5 == 0)
                            _FizzBuzzRes.Add("Buzz");
                    }
                }
            }
        }

        public List<string> GetFizzBuzz(int upperBound)
        {
            this._FizzBuzzRes = new List<string>();
            GenFizzBuzz(upperBound);
            return this._FizzBuzzRes;
        }
    }
}
