using System;
//Write a program that enters from the console a positive integer n and prints all the numbers
//from 1 to n, on a single line, separated by a space.
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter a integer N :)");
            int GivenInteger = int.Parse(Console.ReadLine());
            Console.WriteLine("Printing positive integers from 1 to N");
            for (int i = 1; i < GivenInteger; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

