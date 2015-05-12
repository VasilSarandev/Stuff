using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that reads two integer arrays from the console and compares them element by element.
 */

namespace _02.Compare_Arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount of integers in both Arrays : ");
            int AmountElements = int.Parse(Console.ReadLine());
            int[] Array1 = new int[AmountElements];
            int[] Array2 = new int[AmountElements];
            Console.WriteLine("Now please enter elements for Array 1.");
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine("Entering element {0} for Array 1. {1} left.", i, Array1.Length - i);
                Array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Now please enter elements for Array 2.");
            for (int i = 0; i < Array2.Length; i++)
            {
                Console.WriteLine("Entering element {0} for Array 2. {1} left.", i, Array2.Length - i);
                Array2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Now comparing both arrays by elements at same index.");
            for (int i = 0; i < AmountElements; i++)
            {
                if (Array1[i] == Array2[i])
                {
                    Console.WriteLine("{0} equals {1} , index is {2}", Array1[i], Array2[i], i);
                }
                else
                {
                    Console.WriteLine("{0} does not equal {1}, index is {2}", Array1[i], Array2[i], i);
                }
            }
        }
    }
}
