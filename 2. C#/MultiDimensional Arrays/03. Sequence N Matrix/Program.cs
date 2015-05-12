using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*We are given a matrix of strings of size N x M. Sequences in the matrix we 
 *define as sets of several neighbour elements located on the same line, column or diagonal.
 *Write a program that finds the longest sequence of equal strings in the matrix.
 */
namespace _03.Sequence_N_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix rows : ?");
            int matrixRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Matrix columns : ?");
            int matrixCols = int.Parse(Console.ReadLine());
            string[,] stringMatrix = new string[matrixRows, matrixCols];
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.WriteLine("Element [{0}.{1}] of matrix is ... ? ", row, col);
                    stringMatrix[row, col] = Console.ReadLine();
                }
            }
            int currLengthVertical = 0;
            int bestLengthVertical = 0;
            string CompleteString = "";
            string CurrentString = "";
            string CurrElement = "";
            int counter = 0;
            //check vertically first.
            
            
                for (int col = 0; col < matrixCols; col++)
                {
                    CurrElement = stringMatrix[counter, col];
                    for (int row = 0; row < matrixRows; row++)
                    {
                        if (stringMatrix[row, col] == CurrElement)
                        {
                            currLengthVertical++;
                            CurrentString += stringMatrix[row, col];
                        }
                        if (currLengthVertical > bestLengthVertical)
                        {
                            bestLengthVertical = currLengthVertical;
                            CompleteString = CurrentString;
                        }
                        
                    }
                    counter++;
                    currLengthVertical = 0;
                    CurrentString = "";
                }
                //complete string = result of vertical search.
            //check horisontal now... easiest part i guess.
                int currLengthHorisontal = 0;
                int bestLengthHorisontal = 0;
                string CompleteStringHorisontal = "";
                string CurrStringHorisontal = "";
                
                counter = 0;
                for (int row = 0; row < matrixRows; row++)
                {
                    
                    for (int col = 0; col < matrixCols-1; col++)
                    {
                        if (stringMatrix[row, col] == stringMatrix[row, col + 1])
                        {
                            currLengthHorisontal++;
                            if (counter == 0)
                            {
                                CurrStringHorisontal += stringMatrix[row, col];
                                currLengthHorisontal++;
                                counter++;
                            }
                            CurrStringHorisontal += stringMatrix[row, col+1];

                        }
                        if (currLengthHorisontal > bestLengthHorisontal)
                        {
                            bestLengthHorisontal = currLengthHorisontal;
                            CompleteStringHorisontal = CurrStringHorisontal;
                        }
                        
                    }
                    currLengthHorisontal = 0;
                    CurrStringHorisontal = "";
                    counter = 0;
                }
                //complete string horisontal = result from horisontal search.
            //now search diagonal :|
                int currLengthDiagonal = 0;
                int BestLengthDiagonal = 0;
                string CompleteStringDiagonal = "";
                int count = 0;
                for (int row = 0; row < matrixRows; row++)
                {
                    for (int col = 0; col < matrixCols; col++)
                    {
                        count = 0;
                        string checkString = stringMatrix[row, col];
                        for (int i = row, j = col; i < stringMatrix.GetLength(0) && j < stringMatrix.GetLength(1); i++, j++)
                        {
                            if (stringMatrix[i, j] == checkString)
                            {
                                ++count;
                                currLengthDiagonal = count;
                            }
                            else
                                break;
                        }
                        if (currLengthDiagonal > BestLengthDiagonal)
                        {
                            BestLengthDiagonal = currLengthDiagonal;
                            for (int i = 0; i < BestLengthDiagonal; i++)
                            {
                                CompleteStringDiagonal += checkString + " ";
                            }
                            
                        }
                    }
                }
                    

                       //BestLeng
                Console.WriteLine("Best Sequence : ");
                if (BestLengthDiagonal > bestLengthHorisontal && BestLengthDiagonal > bestLengthVertical)
                {
                    Console.WriteLine("It's Diagonal and its representation is ... ");
                    Console.WriteLine(CompleteStringDiagonal);
                }
                else if (bestLengthHorisontal > BestLengthDiagonal && bestLengthHorisontal > bestLengthVertical)
                {
                    Console.WriteLine("It's Horisontal and its representation is ...");
                    Console.WriteLine(CompleteStringHorisontal);
                }
                else
                {
                    Console.WriteLine("It's Vertical and its representation is ... ");
                    Console.WriteLine(CompleteString);
                }
               

            

        }
        
            
        
    }
}

/*
            //print matrix
            
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.Write("{0} ",stringMatrix[row, col]);
                }
                Console.WriteLine();
            }
             */