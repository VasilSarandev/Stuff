using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads two positive integer numbers and prints how many numbers p 
//exist between them such that the reminder of the division by 5 is 0.


    class NumbersInInterval
    {
        static void Main()
        {
            Console.WriteLine("The first integer is ... ? ");
            int DimensionA = int.Parse(Console.ReadLine());
            Console.WriteLine("The second integer is ... ?");
            int DimensionB = int.Parse(Console.ReadLine());
            int Dividee = 5;
            int counter = 0;
            for (int i = DimensionA; i <= DimensionB; i++)
            {
                if (i % Dividee == 0)
                {
                    Console.WriteLine("{0} is dividale by {1}", i, Dividee);
                    counter++;
                }
            }
            Console.WriteLine("Which means ... {0} integers are dividable by {1} in the given Dimensions ({2} - {3})", counter, Dividee, DimensionA, DimensionB);
        }
    }

