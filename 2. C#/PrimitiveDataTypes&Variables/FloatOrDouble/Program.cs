using System;
/*
Which of the following values can be assigned to a variable of type float 
and which to a variable of type double:
34.567839023, 12.345, 8923.1234857, 3456.091?
 * 
 * float (±1.5 × 10−45 to ±3.4 × 1038): 32-bits, precision of 7 digits
 * double (±5.0 × 10−324 to ±1.7 × 10308): 64-bits, precision of 15-16 digits
 *
 * 
 * */


class FloatOrDouble
    {
        static void Main()
        {
            double IntegerOne = 34.567839023;
            float IntegerTwo = 12.345f;
            double IntegerThree = 8923.1234857;
            float IntegerFour = 3456.091f;
            Console.WriteLine("Original Values of Integers : 34.567839023, 12.345, 8923.1234857, 3456.091");
            Console.WriteLine("Value of Integers after validating them via the smallest possible data type : ");
            Console.WriteLine("{0}, {1}, {2}, {3}", IntegerOne, IntegerTwo, IntegerThree, IntegerFour);
        }
    }

