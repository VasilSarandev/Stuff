using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Digits
{
    
    class Program
    {
        static int[,] digits;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            digits = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');
                for (int col = 0; col < currentLine.Length; col++)
                {
                    digits[row, col] = int.Parse(currentLine[col]);
                }
            }
            int sum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    switch (digits[row, col])
                    {
                        case 3: if (CheckIfPatternIsThree(row, col)) sum += 3; break;




                        default: break;
                    }
                }
            }

        }
        static bool CheckIfPatternIsThree(int row, int col)
        {


        }
    }
}
