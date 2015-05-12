using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseDaNumber();
        }
        static void ReverseDaNumber()
        {
            Console.WriteLine("Give me something to reverse :)");
            string givenInput = Console.ReadLine();
            char[] givenInputCharArray = givenInput.ToCharArray();
            Array.Reverse(givenInputCharArray);
            string reversed = new string(givenInputCharArray);

            Console.WriteLine("Reversed: {0}", reversed);
        }
    }
}
