using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
/*
Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
*/

    class TrailZeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter N.");
            int GivenN = int.Parse(Console.ReadLine());
            BigInteger FactorialN = Factorial(GivenN);
            string StringifiedFactorial = FactorialN.ToString();
            int[] SavingIndexesToCheckIfZerosAreInARow;
            SavingIndexesToCheckIfZerosAreInARow = new int[140];
            int CounterOfZeros = 0;
            for (int i = StringifiedFactorial.Length-1; i >= 0; i--)
            {
                if (StringifiedFactorial[i] == '0')
                {
                    CounterOfZeros++;
                }

            }
        }
        private static BigInteger Factorial(int GivenN)
        {
            if (GivenN == 0) return 1;
            return GivenN * Factorial(GivenN - 1);
        }
    }


