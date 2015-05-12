using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/


    class DecimalToX
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter an integer so I can convert it to its HexaDecimal representation.");
            int GivenInteger = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} 's HexaDecimal Representation is ... {1}", GivenInteger, ActualHexRepresentation(GivenInteger));

        }
        public static string DigitToHex(int GivenInteger)
        {
            switch (GivenInteger)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    return GivenInteger.ToString();
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
                default: return String.Empty;
            }
        }
        public static string ReverseHex(string hexRepresentation)
        {
            var temporary = hexRepresentation.ToCharArray();
            Array.Reverse(temporary);
            return new String(temporary);
        }
        public static string ActualHexRepresentation(int GivenInteger)
        {
            string HexRepresentation = "";
            while (GivenInteger > 0)
            {
                HexRepresentation +=  DigitToHex(GivenInteger % 16);
                GivenInteger = GivenInteger / 16;
            }
            return ReverseHex(HexRepresentation);
        }

    }

