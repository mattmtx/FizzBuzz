using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();
            Console.WriteLine("Value of index 5:");
            Console.WriteLine(fb[5]);
            Console.WriteLine("=================");

            IEnumerable<string> results = fb.GetFizzBuzz(20);
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
