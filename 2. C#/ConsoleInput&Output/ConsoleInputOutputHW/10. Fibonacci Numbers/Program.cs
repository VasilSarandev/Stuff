using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that reads a number n and prints on the console the first n members of the 
 * Fibonacci sequence (at a single line, separated by comma and space - ,) 
 * : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 * Note: You may need to learn how to use loops.
 * 
 * 
 * 
 * */

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer N.");
            int GivenInteger = int.Parse(Console.ReadLine());
            Console.WriteLine("The Fabunacci Sequence looks like .... : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. ");
            Console.WriteLine("Now i'll print the first N numbers of the Fibonacci sequence.");
            Array NumsArray = new Array[GivenInteger];
            
        }
    }

