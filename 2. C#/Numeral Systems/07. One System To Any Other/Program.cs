using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.One_System_To_Any_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are converting from base.... :(2/10/16 etc..) ");
            int fromBase = int.Parse(Console.ReadLine());
            Console.WriteLine("To base .... : ");
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Our number is ... ?");
            string givenInput = Console.ReadLine();
            string resultRepresentation = Convert.ToString(Convert.ToInt32(givenInput, fromBase), toBase);
            Console.WriteLine("Result representation in {0} base is {1}", toBase, resultRepresentation);
        }
    }
}
