using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
 * Use only one loop.
 */


    class FactorialDivision
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter N ...");
            int GivenN = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi. Please enter K ...");
            int GivenK = int.Parse(Console.ReadLine());
            BigInteger FactorialN = Factorial(GivenN);
            BigInteger FactorialK = Factorial(GivenK);
            BigInteger result = FactorialN / FactorialK;
            Console.WriteLine("{0}! / {1}! = {2}", GivenN, GivenK, result);
        }
        private static BigInteger Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }

