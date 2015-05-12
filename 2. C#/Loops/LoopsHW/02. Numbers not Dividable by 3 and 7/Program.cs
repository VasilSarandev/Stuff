using System;
/*
 * Write a program that enters from the console a positive integer n and prints all
 * the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
 */

    class NotDivisibleNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a integer N. :)");
            int GivenInteger = int.Parse(Console.ReadLine());
            for (int i = 0; i < GivenInteger; i++)
            {
                if (i % 7 != 0 && i%3!=0)
                {
                    Console.Write(" "+i);
                }
            }
            Console.WriteLine("\nNumbers from 1-{0} not divisible by 3 and 7 Printed.", GivenInteger);
        }
    }

