using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _10.N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensionA = 1;
            int dimensionB = 100;
            for (int i = dimensionA; i <= dimensionB; i++)
            {
                Console.WriteLine("Factorial of {0} is ... {1}", i, CalcFactorial(i));
            }
        }
        static BigInteger CalcFactorial(int N)
        {
            BigInteger result = 1;
            for (int i = 1; i <= N; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
