using System;
using System.Text;
/* Using loops write a program that converts a binary integer number to its decimal form.
 *The input is entered as string. The output should be a variable of type long.
 *Do not use the built-in .NET functionality.
 * 
 * 
 * 
 * */

    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please give me a binary integer number.");
            string input = Console.ReadLine().Trim();
            int DecimalNumber = 0;
            for(int i= input.Length-1, counter=0; i>=0; i--, counter++) 
            {
                DecimalNumber += int.Parse(input[i].ToString()) * (int)Math.Pow(2, counter);
            }
            Console.WriteLine(DecimalNumber);
        }
    }

