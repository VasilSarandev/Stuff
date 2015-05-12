using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Enters Number in a single line, separated by space.");
            string GivenNumbers = Console.ReadLine();
            string[] GivenNumbersSeparated = GivenNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] OddGivenNumbers;
            OddGivenNumbers = new int[GivenNumbersSeparated.Length / 2 + 1];
            OddGivenNumbers[GivenNumbersSeparated.Length / 2] = 1;
            int[] EvenGivenNumbers;
            EvenGivenNumbers = new int[GivenNumbersSeparated.Length / 2];
            int EvenCounter = 0;
            int OddCounter = 0;
            
            for (int i = 0; i < GivenNumbersSeparated.Length; i++)
            {
                if (i % 2 == 0)
                {
                    OddGivenNumbers[OddCounter] = int.Parse(GivenNumbersSeparated[i]);
                    OddCounter++;

                }
                else
                {
                    EvenGivenNumbers[EvenCounter] = int.Parse(GivenNumbersSeparated[i]);
                    EvenCounter++;
                }
            }
            int EvenNumbersProduct = 1;
            int OddNumbersProduct = 1;
            for (int i = 0; i < EvenGivenNumbers.Length; i++)
            {
                EvenNumbersProduct = EvenNumbersProduct * EvenGivenNumbers[i];
                Console.WriteLine("Now Product is ... {0}", EvenNumbersProduct);
            }
            
            for (int i = 0; i < OddGivenNumbers.Length; i++)
            {
                OddNumbersProduct = OddNumbersProduct * OddGivenNumbers[i];
                Console.WriteLine("Now Product is ... {0}", OddNumbersProduct);
            } 
            //tests to see what's wrong
            Console.WriteLine("Odd integers array :");
            for (int j = 0; j < OddGivenNumbers.Length; j++)
            {
                Console.WriteLine(OddGivenNumbers[j]);
            }
            Console.WriteLine("Even integers array :");
            for (int k = 0; k < EvenGivenNumbers.Length; k++)
            {
                Console.WriteLine(EvenGivenNumbers[k]);
            }
           // Console.WriteLine(EvenNumbersProduct);
           // Console.WriteLine(OddNumbersProduct);
            //end of tests1

                if (EvenNumbersProduct == OddNumbersProduct)
                {
                    Console.WriteLine("Products are equal.");
                }
                else
                {
                    Console.WriteLine("Products are NOT equal.");
                }
        }
    }

