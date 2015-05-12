using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿//Write a program that reads from the console a positive integer number n 
//(1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Hi. Please give me N :) ");
            int GivenN = int.Parse(Console.ReadLine());
           

            for (int i = 1; i <= GivenN; i++)
            {
                for (int j = i; j < i + GivenN; j++)
                {
                    Console.Write("{0,2}", j);
                }
                Console.WriteLine();
            }
        }
    }

