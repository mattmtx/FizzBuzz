using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzNS
{
    public class FizzBuzz
    {
        // List<T> will preserve order
        public List<KeyValuePair<int, string>> MultipleNamePair = 
            new List<KeyValuePair<int, string>>()
        {
            new KeyValuePair<int, string>(3, "Fizz"),
            new KeyValuePair<int, string>(5, "Buzz"),
        };
        
        public void SetMultipleNamePair(int multiple1, string word1, 
                                        int multiple2, string word2)
        {
            MultipleNamePair = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(multiple1, word1),
                new KeyValuePair<int, string>(multiple2, word2),
            };
            validateMultipleNamePair();
        }

        private string fizzBuzzGenerator(int i)
        {
            StringBuilder outputLine = new StringBuilder();

            foreach (KeyValuePair<int, string> multipleName in MultipleNamePair)
            {
                if (i % multipleName.Key == 0)
                    outputLine.Append(multipleName.Value);
            }
            if (outputLine.Length == 0)
                return i.ToString();
            return outputLine.ToString();
        }

        private void validateMultipleNamePair()
        {
            if (MultipleNamePair == null)
                throw new Exception("Invalid MultipleNamePair.  Should be of Type " +
                    "List<KeyValuePair<int, string>, or set using SetMultipleWord() function.");
        }

        public string this[int i]
        {
            get
            {
                validateMultipleNamePair();
                return fizzBuzzGenerator(i+1);
            }
        }

        public IEnumerable<string> GetFizzBuzz(int upperBound)
        {
            validateMultipleNamePair();
            for(int i = 1; i <= upperBound; i++)
            {
                yield return fizzBuzzGenerator(i);
            }
        }
    }
}
