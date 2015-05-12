using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Peace_of_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //A/B C/D
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());
            long D = long.Parse(Console.ReadLine());
            long resultDenominator = B * D;
        
            decimal result = (decimal)A / B + (decimal)C / D;
            if (result>=1)
            {
                Console.WriteLine((int)result);
                
            }
            else
            {
                Console.WriteLine("{0:F22}", result);
        
            }
            Console.WriteLine("{0}/{1}", A*D+ C*B, resultDenominator);
        }
    }
}
