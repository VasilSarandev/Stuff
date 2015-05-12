using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Write a method that checks if the element at given position 
 *in given array of integers is larger than its two neighbours (when such exist). 
 */
namespace _05.Larger_Than_Neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Integer at given index > his neighbours... {0}", CheckIfLarger());
        }
        static bool CheckIfLarger()
        {
            bool result = false;
            Console.WriteLine("Hi. Please enter elements of array , separated by space.");
            string givenInput = Console.ReadLine();
            string[] givenInputArray = givenInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] givenIntegerArray = new int[givenInputArray.Length];
            for (int i = 0; i < givenInputArray.Length; i++)
            {
                givenIntegerArray[i] = int.Parse(givenInputArray[i]);
            }
            Console.WriteLine("Hi again. Please enter position of integer you want me to check.");
            int givenPosition = int.Parse(Console.ReadLine());
            if (givenIntegerArray.Length > 2 && givenPosition > 0 && givenPosition < givenIntegerArray.Length - 1)
            {
                if (givenIntegerArray[givenPosition] > givenIntegerArray[givenPosition - 1] && givenIntegerArray[givenPosition] > givenIntegerArray[givenPosition + 1])
                {
                    result = true;
                }
            }
            return result;

        }
    }
}
