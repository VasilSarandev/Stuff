using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a rectangular matrix of size N x M and finds
//in it the square 3 x 3 that has maximal sum of its elements.
namespace _02.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix rows : ");
            int matrixRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Matrix cols : ");
            int matrixCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixRows, matrixCols];
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.WriteLine("Matrix[{0},{1}] = ... ?", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            int currSum = 0;
            int bestSum = 0;
            for (int row = 1; row < matrixRows - 1; row++)
            {
                for (int col = 1; col < matrixCols - 1; col++)
                {
                    currSum += matrix[row, col];
                    currSum += matrix[row, col + 1];
                    currSum += matrix[row, col - 1];
                    currSum += matrix[row - 1, col];
                    currSum += matrix[row - 1, col + 1];
                    currSum += matrix[row - 1, col - 1];
                    currSum += matrix[row + 1, col];
                    currSum += matrix[row + 1, col + 1];
                    currSum += matrix[row + 1, col - 1];
                    if (currSum > bestSum)
                    {
                        bestSum = currSum;
                    }
                    currSum = 0;
                }
            }
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.Write(" {0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
                Console.WriteLine("Best sum is ... {0}", bestSum);
        }
    }
}
