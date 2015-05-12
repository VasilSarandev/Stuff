using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum. 
 
 */
namespace _06.Maximal_K_sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter N. ");
            int ArrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter K.");
            int amountOfElements = int.Parse(Console.ReadLine());
            Console.WriteLine("Now lets enter elements of array with length {0}", ArrayLength);
            int[] IntegersArray = new int[ArrayLength];
            int currBestIndex = 0;
            int sum = 0;
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("Please enter element # {0} of Array.", i);
                IntegersArray[i] = int.Parse(Console.ReadLine());
            }
            //ok array is read and validated. now implement functionality

            for (int i = 0; i < amountOfElements; i++)
            {
                sum += IntegersArray.Max();
                for (int j = 0; j < IntegersArray.Length; j++)
                {
                    if (IntegersArray[j] == IntegersArray.Max())
                    {
                        IntegersArray[j] = 0;
                        break;
                    }
                }
            }
            Console.WriteLine("Biggest sum of {0} elements is {1}", amountOfElements, sum);


        }
    }
}
