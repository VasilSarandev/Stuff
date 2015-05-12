using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexaDecimal_To_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please give me a XDecimal number so i can convert it to Binary :)");
            string givenX = Console.ReadLine();
            string binaryRepresentation = Convert.ToString(Convert.ToInt32(givenX, 16), 2).PadLeft(32, '0');
            Console.WriteLine("Binary representation is ... : ");
            Console.WriteLine(binaryRepresentation);
        }
    }
}
