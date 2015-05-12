using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Binary_To_XDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please give me a binary number so i can convert it XDecimal.");
            string binaryPresentation = Console.ReadLine();
            string xDecimalRepresentation = Convert.ToString(Convert.ToInt32(binaryPresentation, 2), 16);
            Console.WriteLine("HexaDecimal representation is ... {0}", xDecimalRepresentation);

        }
    }
}
