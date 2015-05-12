using System;
/*Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
 *Use Windows Calculator to find its hexadecimal representation.
 *Print the variable and ensure that the result is 254.
 * 
 * 
 * 
 * 
 * */

    class HexaDecimalFormatVariable
    {
        static void Main()
        {
            int HxDeciVariable = 0xFE;
            // (254(10) = FE(16)
            Console.WriteLine("{0} in hexadecimal is {1:X}", HxDeciVariable, HxDeciVariable);
           

        }
    }

