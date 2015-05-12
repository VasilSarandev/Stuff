using System;

//Write a program that finds the biggest of three numbers
    class BiggestThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter Number A. ");
            double DoubleA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number B. ");
            double DoubleB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number C. ");
            double DoubleC = double.Parse(Console.ReadLine());
            Console.WriteLine("Calculating the biggest of three numbers...");
            if (DoubleA > DoubleB & DoubleA > DoubleC)
            {
                Console.WriteLine(DoubleA);
            }
            else if (DoubleB > DoubleA & DoubleB > DoubleC)
            {
                Console.WriteLine(DoubleB);
            }
            else
            {
               Console.WriteLine(DoubleC);
            }
        }
    }

