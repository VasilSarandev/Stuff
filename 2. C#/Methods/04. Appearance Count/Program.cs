using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
 */
namespace _04.Appearance_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCount();
        }
        public static void GetCount()
        {
            Console.WriteLine("Please enter elements of array, separated by space.");
            string givenInput = Console.ReadLine();
            string[] givenInputToArray = givenInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] givenIntegerArray = new int[givenInputToArray.Length];
            for (int i = 0; i < givenIntegerArray.Length; i++)
            {
                givenIntegerArray[i] = int.Parse(givenInputToArray[i]);
            }
            int count = 0;
            Console.WriteLine("Enter integer to check occurance in array with, please.");
            int givenInteger = int.Parse(Console.ReadLine());
            for (int i = 0; i < givenIntegerArray.Length; i++)
            {
                if (givenIntegerArray[i] == givenInteger)
                {
                    count++;
                }
            }
            Console.WriteLine("The occurance of {0} in given Array is {1}", givenInteger, count);
            bool Correct = CheckIfCorrect(givenIntegerArray, givenInteger, count);
            Console.WriteLine("Method Working correctly... : {0}", Correct);
        }
        public static bool CheckIfCorrect(int[] Array,int SearchedElement, int Occurance)
        {
            int counter=0;
            bool result = false;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == SearchedElement)
                {
                    counter++;
                }
            }
            if (counter == Occurance)
            {
                result = true;
            }
                return result;
        }
    }
}
