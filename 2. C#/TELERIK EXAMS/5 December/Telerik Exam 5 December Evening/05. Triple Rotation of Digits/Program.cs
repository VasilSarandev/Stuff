using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triple_Rotation_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {   

            string givenInteger = Console.ReadLine();
            string GivenInteger = givenInteger;
            string TripleRotation = "";
            int counter = givenInteger.Length;
            char temp= 'a';
            for (int i = 0; i < 3; i++)
            {
                
                TripleRotation += givenInteger[counter-1];
                counter--;
            }
            for (int i = 0; i < givenInteger.Length-3; i++)
            {
                TripleRotation += givenInteger[i];
            }
            //lets test bby
            string NewStringBbyyyy = "";
            //clear zeroes
            for (int i = 0; i < TripleRotation.Length; i++)
            {
                if (TripleRotation[i] != '0')
                {
                    NewStringBbyyyy += TripleRotation[i];
                }
            }
            Console.WriteLine(NewStringBbyyyy);
        }
    }
}
