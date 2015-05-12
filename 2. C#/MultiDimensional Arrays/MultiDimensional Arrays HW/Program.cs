using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:
 */

namespace MultiDimensional_Arrays_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Enter matrix dimensions. (n) :) ");
            int MatrixDimension = int.Parse(Console.ReadLine());
            int matrixRows = MatrixDimension;
            int matrixCols = MatrixDimension;
            int counter = 1;
            int[,] matrixA = new int[MatrixDimension, MatrixDimension];
            #region MatrixA
            Console.WriteLine("Now printing MatrixA.");
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    matrixA[row, col] = counter;
                    counter++;
                }
            }

            
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    
                        Console.Write(" {0} ", matrixA[col,row]);
                   
                   
                }
                Console.WriteLine();
            }
            #endregion
            int[,] matrixB = new int[MatrixDimension, MatrixDimension];
            #region MatrixB
            Console.WriteLine("Now printing MatrixB");
            int firstDigitOfRow = 1;
            int FirstToSecondDiff = 7;
            int SecondToThirdDiff = 1;
            int ThirdToFourDiff = 7;
            //allocate
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    if (col == 0)
                    {
                        matrixB[row, col] = firstDigitOfRow;
                    }
                    if (col == 1)
                    {
                        matrixB[row, col] = firstDigitOfRow + FirstToSecondDiff;
                    }
                    if (col == 2)
                    {
                        matrixB[row, col] = firstDigitOfRow + FirstToSecondDiff + SecondToThirdDiff;
                    }
                    if (col == 3)
                    {
                        matrixB[row, col] = firstDigitOfRow + FirstToSecondDiff + SecondToThirdDiff + ThirdToFourDiff;
                    }
                }
                firstDigitOfRow++;
                FirstToSecondDiff = FirstToSecondDiff - 2;
                SecondToThirdDiff = SecondToThirdDiff + 2;
                ThirdToFourDiff = ThirdToFourDiff - 2;
            }
            //print
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.Write(" {0} ", matrixB[row, col]);
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}
