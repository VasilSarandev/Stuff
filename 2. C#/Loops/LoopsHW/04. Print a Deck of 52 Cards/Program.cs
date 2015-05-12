using System;
/*
 * Write a program that generates and prints all possible cards from a standard deck of 52 cards 
 * (without the jokers). The cards should be printed using the classical notation 
 * (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
 * The card faces should start from 2 to A.
 * Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
 * Use 2 nested for-loops and a switch-case statement.
 * */
    class PrintDeck
    {
        static void Main(string[] args)
        {
            string[] Cards = new string[] {" Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            char[] Suits = new char[] { '\u2665', '\u2660', '\u2666', '\u2660' };
            for (int i = 0; i <= 12; i++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    Console.Write(" {0} {1} ", Cards[i], Suits[suit]);
                }
                Console.Write("\n");
            }
        }
    }

