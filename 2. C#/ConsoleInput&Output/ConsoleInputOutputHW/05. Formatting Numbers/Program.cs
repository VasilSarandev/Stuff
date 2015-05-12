using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.


    class FormattingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Integer A is ... ? ");
            int IntegerA = int.Parse(Console.ReadLine());
            int DimensionA1 = 0;
            int DimensionA2 = 500;
            if (IntegerA > DimensionA1 && IntegerA < DimensionA2 || IntegerA==DimensionA1 || IntegerA==DimensionA2)
            {
                Console.WriteLine("Integer B is ... ?");
                double IntegerB = double.Parse(Console.ReadLine());
                Console.WriteLine("Integer C is ... ?");
                double IntegerC = double.Parse(Console.ReadLine());
                Console.WriteLine("{0, -10}|{1}|{2,10:F2}|{3, -10:F3}|", IntegerA.ToString("X"), Convert.ToString(IntegerA,2).PadLeft(10, '0'),IntegerB,IntegerC);
            }
        }
    }
