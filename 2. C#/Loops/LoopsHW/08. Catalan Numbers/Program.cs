using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//In combinatorics, the Catalan numbers are calculated by the following formula: 

//Write a program to calculate the nth Catalan number by given n (1 < n < 100).


    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please give me an integer N so i can calculate the Nth Catalan Number.");
            int GivenN = int.Parse(Console.ReadLine());
            BigInteger NthCatalanNumber = (Factorial(2 * GivenN)) / (Factorial(GivenN + 1) * Factorial(GivenN));
            Console.WriteLine("Catalan Number # {0} is {1} ", GivenN, NthCatalanNumber);

        }
        public static BigInteger Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }

