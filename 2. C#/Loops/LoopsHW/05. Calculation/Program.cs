
using System;
using System.Numerics;

﻿//Write a program that, for a given two integer numbers n and x, 
//calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. 
//Print the result with 5 digits after the decimal point.

namespace CalculatingFactorial
{
    class CalculatingSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. N is ... ?");
            int GivenN = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi again. X is ... ?");
            int GivenX = int.Parse(Console.ReadLine());
            Console.WriteLine("Calculatin the sum of 1 + 1!/x + 2!/X2 + ... + N!/XN");
            decimal sum = 0;
            for (int i = 0; i <= GivenN; i++)
            {
                sum += (decimal)Factorial(i) / (decimal)Math.Pow(GivenX, i);
            }
            Console.WriteLine("Sum is ... {0:F5}", sum);


        }
        private static  BigInteger       Factorial(int n){
            if(n==0) {
                return 1;
            }
            return n*Factorial(n-1);
        }
    }

}