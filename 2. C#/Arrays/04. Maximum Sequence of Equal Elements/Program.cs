using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that finds the maximum sequence of equal elements in arrays

namespace _04.Maximum_Sequence_of_Equal_Elements
{
    class MaximumSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. please enter an array with its elements separated by space ");
            string givenNumbers = Console.ReadLine();
            string[] givenArray = givenNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int currentElementIndex = 0;
            int CurrentLength = 0;
            int MaxLength = 0;
            string BestElement = "0";


            
            //we got the array now. 
            //time to implement the logic for the task.
            for (int i = 1; i < givenArray.Length; i++)
            {
                if (givenArray[i] == givenArray[currentElementIndex])
                {
                    CurrentLength++;
                }
                else
                {
                    currentElementIndex = i;
                    CurrentLength = 1;
                }
                if (CurrentLength >= MaxLength)
                {
                    MaxLength = CurrentLength;
                    BestElement = givenArray[i];
                }

            }
            for (int i = 0; i < MaxLength; i++)
            {
                Console.Write("{0} ", BestElement);
            }


        }
    }
}
