using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads an integer number n from the console
//and prints all the numbers in the interval [1..n], each on a single line.

    class NumbersFrom1ToN
    {
        static void Main()
        {
            int DimentionA = 1;
            Console.WriteLine("Hi. N is ... ? ");
            int DimentionB = int.Parse(Console.ReadLine());
            Console.WriteLine("Printing integers from 1 to N ...");
            for (var i = DimentionA; i < DimentionB; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

