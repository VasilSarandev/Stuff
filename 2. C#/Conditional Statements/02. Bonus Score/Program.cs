﻿using System;
/*Problem 2. Bonus Score

Write a program that applies bonus score to given score in the range [1…9] by the following rules:
If the score is between 1 and 3, the program multiplies it by 10.
If the score is between 4 and 6, the program multiplies it by 100.
If the score is between 7 and 9, the program multiplies it by 1000.
If the score is 0 or more than 9, the program prints “invalid score”.
 * 
 * 
 * 
 * */

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Score is ... ? ");
            int Score = int.Parse(Console.ReadLine());
            Console.WriteLine("Bonuses will now be applied corresponding to Score value....");
            if (Score => 1 && Score =< 3)
            {
                Score = Score * 10;
            }
            if(Score => 4 && Score =<6) {

}
        }
    }

