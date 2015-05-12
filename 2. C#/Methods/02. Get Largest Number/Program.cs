using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a method GetMax() with two parameters that returns the larger of two integers.
 * Write a program that reads 3 integers from the console and prints the largest of 
 * them using the method GetMax().
 */
namespace _02.Get_Largest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter integer 1 :)");
            int Int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi. Please enter integer 2 :)");
            int Int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi. Please enter integer 3 :) ");
            int Int3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The max is... {0}",GetMax(GetMax(Int1, Int2), Int3));


        }
        static int GetMax(int A, int B)
        {
            if (A > B)
            {
                return A;
            }
            else
            {
                return B;
            }
        }
    }
}
