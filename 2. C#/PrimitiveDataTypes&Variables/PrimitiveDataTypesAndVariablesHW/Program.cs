using System;
/*
Declare five variables choosing for each of them the most appropriate of the types
 * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
 * 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 *sbyte (-128 to 127): signed 8-bit
 byte (0 to 255): unsigned 8-bit
 short (-32,768 to 32,767): signed 16-bit
 ushort (0 to 65,535): unsigned 16-bit
 int (-2,147,483,648 to 2,147,483,647): signed 32-bit
 uint (0 to 4,294,967,295): unsigned 32-bit



*/
class DeclareVariables
    {
        static void Main()
        {
            ushort IntegerOne = 52130;
            sbyte IntegerTwo = -115;
            int IntegerThree = 4825932;
            byte IntegerFour = 97;
            short IntegerFive = -10000;
            Console.WriteLine("Original Values of Integers :52130, -115, 4825932, 97, -10000 ");
            Console.WriteLine("Values of Integers after validating them with the smallest possible data type: ");
            Console.WriteLine("{0} , {1}, {2}, {3}, {4}", IntegerOne, IntegerTwo, IntegerThree, IntegerFour, IntegerFive);
        }
    }

