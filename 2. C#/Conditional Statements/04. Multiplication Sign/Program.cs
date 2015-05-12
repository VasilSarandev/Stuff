using System;
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

    class MultiplicationSign
    {
        static void Main()
        {
            bool AIsPositive = true;
            bool BIsPositive = true;
            bool CIsPositive = true;
            bool ZeroValue = false;
            
            int minusescount = 0;
            Console.WriteLine("Integer A is .... ? ");
            double IntegerA = double.Parse(Console.ReadLine());
            Console.WriteLine("Integer B is .... ?");
            double IntegerB = double.Parse(Console.ReadLine());
            Console.WriteLine("Integer C is .... ?");
            double IntegerC = double.Parse(Console.ReadLine());
            if (IntegerA == 0 | IntegerB == 0 | IntegerC == 0)
            {
                ZeroValue = true;
            }
            if (IntegerA < 0)
            {
                AIsPositive = false;
            }
            if (IntegerB < 0)
            {
                BIsPositive = false;
            }
            if (IntegerC < 0)
            {
                CIsPositive = false;
            }
            if (AIsPositive==false){
                minusescount++;
            }
            if (BIsPositive == false)
            {
                minusescount++;
            }
            if (CIsPositive == false)
            {
                minusescount++;
            }
            if (ZeroValue)
            {
                Console.WriteLine("0");
            }
            if (minusescount % 2 == 0 & ZeroValue!=true)
            {
                Console.WriteLine("+");
            }
            else if(minusescount %2!=0 & ZeroValue!=true)
            {
                Console.WriteLine("-");
            }
            
        }
    }

