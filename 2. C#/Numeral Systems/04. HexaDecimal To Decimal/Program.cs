using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexaDecimal_To_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please give a XDecimal number so i can convert it to Decimal :)");
            string givenX = Console.ReadLine();
            string DecimalRepresentation = Convert.ToString(Convert.ToInt32(givenX, 16), 10);
            Console.WriteLine("Decimal representation of given number is .... {0}", DecimalRepresentation);
        }
    }
}
