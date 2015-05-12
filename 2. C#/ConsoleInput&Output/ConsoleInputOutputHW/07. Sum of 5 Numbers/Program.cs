using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
    class FiveNumbersSum
    {
        static void Main()
        {
            Console.WriteLine("Enter Numbers , separated by space.");
            string GivenNumbers = Console.ReadLine();
            string[] GivenNumbersSeparated = GivenNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            for(int i=0; i<GivenNumbersSeparated.Length; i++) {
                sum = sum + int.Parse(GivenNumbersSeparated[i]);
            }
            Console.WriteLine("The sum of these integers is ... {0}", sum);

        }
    }

