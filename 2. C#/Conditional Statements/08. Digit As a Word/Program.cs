﻿using System;



    class DigitAsAWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a digit 0-9 so i can spell it for you.");
            byte GivenInteger = byte.Parse(Console.ReadLine());
            switch (GivenInteger)
            {
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine.");break;
                default: Console.WriteLine("Inalid digit."); break;

            }
        }
    }

