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
            List<string> fizzBuzzRes = fb.GetFizzBuzz(int.MaxValue);
            foreach (string fbres in fizzBuzzRes)
                Console.WriteLine(fbres);
            Console.ReadKey();
        }


    }
}
