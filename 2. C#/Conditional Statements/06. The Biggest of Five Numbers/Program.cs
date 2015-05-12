using System;
//Write a program that finds the biggest of five numbers by using only five if statements.


    class BiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number A is ... ? ");
            double NumA = double.Parse(Console.ReadLine());
            Console.WriteLine("Number B is ... ? ");
            double NumB = double.Parse(Console.ReadLine());
            Console.WriteLine("Number C is ... ? ");
            double NumC = double.Parse(Console.ReadLine());
            Console.WriteLine("Number D is ... ? ");
            double NumD = double.Parse(Console.ReadLine());
            Console.WriteLine("Number E is ... ? ");
            double NumE = double.Parse(Console.ReadLine());
            Console.WriteLine("Calculating biggest of five...");
            if(NumA > Math.Max(NumB,NumC) & NumA>Math.Max(NumD,NumE))
            {
                Console.WriteLine(NumA);
            }
            else if (NumB > Math.Max(NumA,NumC) & NumB>Math.Max(NumD,NumE)){
                Console.WriteLine(NumB);
            }
            else if (NumC > Math.Max(NumA, NumB) & NumC > Math.Max(NumD, NumE))
            {

                Console.WriteLine(NumC);
            }
            else if (NumD > Math.Max(NumA, NumB) & NumD > Math.Max(NumC, NumE))
            {
                Console.WriteLine(NumD);
            }
            else if (NumE > Math.Max(NumA, NumB) & NumE > Math.Max(NumC, NumD))
            {
                Console.WriteLine(NumE);
            }
            
        }
    }

