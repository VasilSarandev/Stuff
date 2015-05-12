using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position,
find the smallest from the rest, move it at the second position, etc.
 
 */
namespace _07.Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter elements of array separated by space.");
            string givenString = Console.ReadLine();
            string[] givenArray = givenString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] givenArrayToInt = new int[givenArray.Length];
            for (int i = 0; i < givenArrayToInt.Length; i++)
            {
                givenArrayToInt[i] = int.Parse(givenArray[i]);
            }
            //ok got array. now sort.
            int[] helpingArray = new int[givenArray.Length];
            for (int i = 0; i < givenArrayToInt.Length; i++)
            {
                helpingArray[i] = givenArrayToInt.Max();
                //now remove max from actual array.
                for (int j = 0; j < givenArrayToInt.Length; j++)
                {
                    if (givenArrayToInt[j] == givenArrayToInt.Max())
                    {
                        givenArrayToInt[j] = 0;
                        break;
                    }
                }
                //this should work.
            }
            //now print new sorted array.
            Console.WriteLine("Array sorted : ");
            for (int i = 0; i < helpingArray.Length; i++)
            {
                Console.Write("{0} ", helpingArray[i]);
            }
            //all good.
        }
    }
}
