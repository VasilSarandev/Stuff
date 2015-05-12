using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/

    class HexaDecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter HexaDecimal Integer so  i can convert it to Decimal type. :)");
            string HexInt = Console.ReadLine().Trim();
            Console.WriteLine("{0} in HexaDecimal is ... {1} in Decimal.", HexInt, DigitsToDecimal(HexInt));


        }
        public static int HexDigitToDecimalDigit(char digit)
        {
            switch (digit)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return int.Parse(digit.ToString());
                case 'A': return 10;
                case 'B': return 11;
                case 'C': return 12;
                case 'D': return 13;
                case 'E': return 14;
                case 'F': return 15;
                default: return 0;
            }
        
        }
        public static int DigitsToDecimal(string HexInt)
        {
            int DecimalInteger = 0;
            for (int i = HexInt.Length - 1, counter = 0; i >= 0; i--, counter++)
            {
                DecimalInteger += HexDigitToDecimalDigit(HexInt[i]) * (int)Math.Pow(16, counter);
            }
            return DecimalInteger;
        }
    }

