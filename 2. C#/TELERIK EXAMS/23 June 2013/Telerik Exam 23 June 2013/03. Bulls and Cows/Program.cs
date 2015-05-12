using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bulls_and_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            int GuessedNumber = int.Parse(Console.ReadLine());
            int temp = GuessedNumber;
            int bulls = int.Parse(Console.ReadLine()); //bulls = same position, same value 
            int cows = int.Parse(Console.ReadLine()); //cows = different position, same value. 
            //numbers to check from array.
            int[] CheckArray = new int[9000];
            for (int i = 0; i < 9000; i++)
            {
                CheckArray[i] = i + 1000;
            }
            int bullsCount = 0;
            int cowsCount = 0;
            //to check for bulls and cows i'll transform integer array to string array.
            string[] StringCheckArray = new String[9000];
            for (int i = 0; i < 9000; i++)
            {
                StringCheckArray[i] = CheckArray[i].ToString();
            }
            //now and original num to string array
            string[] GuessedNum = new string[4];
            for (int i = 0; i < 4; i++)
            {
                string temporary = (GuessedNumber % 10).ToString();
                GuessedNumber /= 10;
                GuessedNum[i] = temporary;
                
            }
            //reverse da array
            int counter = 3;
            for (int i = 0; i < 2; i++)
            {
                string temporary = GuessedNum[i];
                GuessedNum[i] = GuessedNum[counter];
                GuessedNum[counter] = temporary;
                counter--;

            }
            //now do checks.
            for (int i = 0; i < StringCheckArray.Length; i++)
            {
                cowsCount=0;
                bullsCount=0;
                for (int j = 0; j < StringCheckArray[i].Length; j++)
                {
                    //cows
                    if ((StringCheckArray[i][j]).ToString() == GuessedNum[j])
                    {
                        cowsCount++;
                    }
                    //bulls
                    for (int k = 0; k < 4; k++)
                    {
                        if ((StringCheckArray[i][j]).ToString() == GuessedNum[k])
                        {
                            bullsCount++;
                        }
                    }
                        
                    if (cowsCount == cows && bullsCount == bulls)
                    {
                        Console.Write("{0} ", StringCheckArray[i]);
                    }
                }
            }
            
        }
    }
}
