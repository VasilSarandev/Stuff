using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double IntegerA = double.Parse(Console.ReadLine());
            int SecretCode = int.Parse(Console.ReadLine());
            double IntegerC = double.Parse(Console.ReadLine());
            double Result = 0;
            if (SecretCode == 3)
            {
                Result = IntegerA + IntegerC;
            }
            if (SecretCode == 6)
            {
                Result = IntegerA * IntegerC;
            }
            if (SecretCode == 9)
            {
                Result = IntegerA % IntegerC;
            }
            if (Result % 3 == 0)
            {
                Console.WriteLine(Result / 3);
            }
            else
            {
                Console.WriteLine(Result % 3);
            }
            Console.WriteLine(Result);
        }
    }
}
