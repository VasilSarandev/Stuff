using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * In combinatorics, the number of ways to choose k different members out of a group of n different elements 
 * (also known as the number of combinations) is calculated by the following formula: formula For example,
 * there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
 * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
 * Try to use only two loops.
 */

    class FactCalculus
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter N ...");
            int GivenN = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi. Please enter k ...");
            int GivenK = int.Parse(Console.ReadLine());
            BigInteger FactorialN = Factorial(GivenN);
            BigInteger FactorialK = Factorial(GivenK);
            BigInteger FactorialNMinK = Factorial(GivenN - GivenK);
            BigInteger result = FactorialN / (FactorialK * FactorialNMinK);
            Console.WriteLine("{0} ! / ({1}! * ({0} - {1})!) = {2}", GivenN, GivenK, result);
            
            
        }
        private static BigInteger Factorial(int n){
            if (n == 0)
            {
                return 1;
            }
            return n*Factorial(n-1);
        }
    }

