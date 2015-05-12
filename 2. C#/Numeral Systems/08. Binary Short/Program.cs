using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Binary_Short
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please give me an integer so i can show you its binary 16-bit representation :)");
            string givenInput = Console.ReadLine();
            string binary16BitRepresentation = Convert.ToString(Convert.ToInt32(givenInput, 10), 2).PadLeft(16, '0');
            Console.WriteLine(binary16BitRepresentation);
        }
    }
}
