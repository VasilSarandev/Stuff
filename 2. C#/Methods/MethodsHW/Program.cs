using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
 */
namespace MethodsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            string Output = PrintName();
            Console.WriteLine(Output);
            if (Output.Contains("Hello,"))
            {
                Console.WriteLine("Method is working correctly.");
            }
            else
            {
                Console.WriteLine("Method is not working correctly.");
            }
          

        }
        public static string PrintName()
        {
            Console.WriteLine("Hi, what's your name :) ?");
            string givenInput = Console.ReadLine();
            return String.Format("Hello, {0}", givenInput);
        }
    }
}
