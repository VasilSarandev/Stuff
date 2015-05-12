using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeral_Systems_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi please enter integer so i can convert it to binary.");
            string givenInteger = Console.ReadLine();
            string binaryRepresentation = Convert.ToString(Convert.ToInt32(givenInteger, 10), 2).PadLeft(32, '0') ;
            Console.WriteLine(binaryRepresentation);

        }
    }
}
