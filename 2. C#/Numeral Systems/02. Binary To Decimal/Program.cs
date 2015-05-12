using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_To_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter binary number so i can convert it to decimal :) ");
            string binaryPresentation = Console.ReadLine();
            string decimalRepresentation = Convert.ToString(Convert.ToInt32(binaryPresentation,2),10);
            Console.WriteLine("Decimal representation is ... {0} ", int.Parse(decimalRepresentation));
        }
    }
}
