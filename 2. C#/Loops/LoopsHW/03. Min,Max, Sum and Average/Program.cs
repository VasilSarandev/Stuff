using System;
using System.Linq;
/*
 * Write a program that reads from the console a sequence of n integer numbers and 
 * the minimal, the maximal number, the sum and the average of all numbers 
 * (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
*/
    class MinMaxAvg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. The count of integers you want to validate is ( N ) ?");
            int GivenInteger = int.Parse(Console.ReadLine());
            //validating Array to operate with.
            int[] NumbersArray;
            NumbersArray = new int[GivenInteger];
            for (int i = 0; i < GivenInteger; i++)
            {
                Console.WriteLine("Please enter integer # {0}", i);
                NumbersArray[i] = int.Parse(Console.ReadLine());

            }
            //sum
            int sum = 0;
            for (int i = 0; i < NumbersArray.Length; i++)
            {
                sum += NumbersArray[i];
            }
            Console.WriteLine("The sum of the integers is ... {0}", sum);
            //Minimum
            int Minimum = NumbersArray.Min();
            Console.WriteLine("The minimum of the integers is ... {0}", Minimum);
            //Maximum
            int Maximum = NumbersArray.Max();
            Console.WriteLine("The maximum of the integers is ... {0}", Maximum);
            //Average
            double Avg = NumbersArray.Average();
            Console.WriteLine("The average of the integers is ... {0}", Avg);



        }
    }

