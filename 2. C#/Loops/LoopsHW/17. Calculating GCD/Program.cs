using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
 *Use the Euclidean algorithm (find it in Internet).
 * 
 * 
 * */

    class CalculateGCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please Enter A .");
            int GivenA = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi. Please Enter B .");
            int GivenB = int.Parse(Console.ReadLine());
            Console.WriteLine("The Greatest Commond Divisor of {0} and {1} is {2}", GivenA, GivenB, GCD(GivenA, GivenB));

        }
        private static int GCD(int a, int b)
        {
            int remainder = 0;
            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }

