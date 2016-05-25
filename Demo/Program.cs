﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzzDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz.FizzBuzz fb = new FizzBuzz.FizzBuzz();
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