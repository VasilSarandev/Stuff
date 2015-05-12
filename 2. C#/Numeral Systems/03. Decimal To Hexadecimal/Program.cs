using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Decimal_To_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please give me a decimal integer so i can convert it to XDecimal.");
            string decimalPresentation = Console.ReadLine();
            string xRepresentation = Convert.ToString(Convert.ToInt32(decimalPresentation, 10), 16).PadLeft(32, '0');
            Console.WriteLine("HexaDecimal representation : ");
            Console.WriteLine(xRepresentation);
            
            
        }
    }
}
