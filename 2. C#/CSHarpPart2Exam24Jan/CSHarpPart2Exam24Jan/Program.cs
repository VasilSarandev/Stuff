using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CSHarpPart2Exam24Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            string strangeNumber = Console.ReadLine()
            .Replace("f", "0")
            .Replace("bIN", "1")
            .Replace("oBJEC", "2")
            .Replace("mNTRAVL", "3")
            .Replace("lPVKNQ", "4")
            .Replace("pNWE", "5")
            .Replace("hT", "6");
            BigInteger result = 0;
            long multiplier = 1;
            BigInteger strangeBigInteger = BigInteger.Parse(strangeNumber);
            for(int i=strangeNumber.Length-1; i>=0; i--)
            {
                result += (strangeNumber[i] - '0') * multiplier;
                multiplier *= 7;
            }
            Console.WriteLine(result);
            
        }
    }
}
