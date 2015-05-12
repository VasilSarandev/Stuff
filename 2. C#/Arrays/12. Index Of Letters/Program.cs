using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
     * 
     * Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
     */
namespace _12.Index_Of_Letters
{
    
    class Program
    {
        static void Main(string[] args)
        {
            char[] AlphabetArray = new char[26];
            int counter = 0;
            for (int i = 97; i < 123; i++)
            {
                AlphabetArray[counter] = (char)i;
                counter++;
            }
            //got alphabet in array. Now functionality for reading word and printing index.
            Console.WriteLine("Hi. Please give me a word so i can tell you indexes of each letter. Lowercase only please . :)");
            
            string givenWord = Console.ReadLine();
            Console.WriteLine("Now priting indexes of letters... ");
            for (int i = 0; i < givenWord.Length; i++)
            {
                for (int j = 0; j < AlphabetArray.Length; j++)
                {
                    if (givenWord[i] == AlphabetArray[j])
                    {
                        Console.Write("{0} ", j);
                    }
                }
            }
        }
    }
}
