using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ComparingNumbersWithoutIF
    {
        static void Main()
        {
            Console.WriteLine("Enter Integer A ... ");
            int IntegerA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Integer B ... ");
            int IntegerB = int.Parse(Console.ReadLine());
            Console.WriteLine("The Greater is ... {0}", Math.Max(IntegerA, IntegerB));
        }
    }

