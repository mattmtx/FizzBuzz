using FizzBuzzNS;
using System;
using System.Collections.Generic;

namespace FizzBuzzDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize default Fizz Buzzer
            FizzBuzz fb = new FizzBuzz();
            
            // Access a single element
            Console.WriteLine("Value of index 5:");
            Console.WriteLine(fb[5]);
            Console.WriteLine("=================");

            // Iterate over the FizzBuzz results from 1..20
            Console.WriteLine("\nDefault FizzBuzz results from 1..20:");
            Console.WriteLine("=================");
            IEnumerable<string> results = fb.GetFizzBuzz(20);
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            // Demo setting the Multiple Name Pair different than default
            fb.SetMultipleNamePair(3, "Hire", 5, "MattM");

            // Iterate over the FizzBuzz results from 1..20
            Console.WriteLine("\nNon-default FizzBuzz results from 1..20:");
            Console.WriteLine("=================");
            results = fb.GetFizzBuzz(20);
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
