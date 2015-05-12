using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * Write a method that returns the last digit of given integer as an English word.
 * 
 */
namespace _03.English_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnWord();

        }
        static void ReturnWord()
        {
            Console.WriteLine("Enter integer, please :)");
            int LastDigit = int.Parse(Console.ReadLine()) % 10;
            switch (LastDigit)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: Console.WriteLine("Not a valid digit."); break;

            }
        }
    }
}
