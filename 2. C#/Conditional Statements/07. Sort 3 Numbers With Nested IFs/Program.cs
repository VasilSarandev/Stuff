using System;
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.


    class SortingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1 is ... ?");
            double NumA = double.Parse(Console.ReadLine());
            Console.WriteLine("Number 2 is ... ?");
            double NumB = double.Parse(Console.ReadLine());
            Console.WriteLine("Number 3 is ... ?");
            double NumC = double.Parse(Console.ReadLine());
            if (NumA > NumB && NumA > NumC)
            {
                if (NumB > NumC)
                {
                    Console.WriteLine("{0} > {1} > {2}", NumA, NumB, NumC);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", NumA,NumC,NumB);
                }
            }
            if (NumB > NumA && NumB > NumC)
            {
                if (NumA > NumC)
                {
                    Console.WriteLine("{0} > {1} > {2}", NumB, NumA, NumC);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", NumB, NumC, NumA);
                }
            }
            if (NumC > NumA && NumC > NumB)
            {
                if (NumA > NumB)
                {
                    Console.WriteLine("{0} > {1} > {2}", NumC, NumA, NumB);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", NumC, NumB, NumA);
                }
            }
        }
    }

