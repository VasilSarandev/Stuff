using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
/*
Write a method that adds two positive integer numbers represented as arrays of 
digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
*/
namespace _08.Number_as_array
{
    class Program
    {
        static void Main(string[] args)
        {
            AddIntegers();
        }
        static void AddIntegers()
        {
            Console.WriteLine("Enter elements(integers) of array 1, separated by space.");
            string givenInput1 = Console.ReadLine();
            Console.WriteLine("Enter elements(integers) of array 2, separated by space.");
            string givenInput2 = Console.ReadLine();
            string[] givenStringArray1 = givenInput1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] givenStringArray2 = givenInput2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string string1 = "";
            string string2 = "";
            for (int i = 1; i < givenStringArray1.Length; i++)
            {
                string1 += givenStringArray1[i];
            }
            for (int i = 1; i < givenStringArray2.Length; i++)
            {
                string2 += givenStringArray2[i];
            }
            string1 += givenStringArray1[0];
            string2 += givenStringArray2[0];

            BigInteger Integer1 = BigInteger.Parse(string1);
            BigInteger Integer2 = BigInteger.Parse(string2);
            BigInteger result = Integer1 + Integer2;
            Console.WriteLine("The result integer is ... {0}", result);
            
        }
    }
}
