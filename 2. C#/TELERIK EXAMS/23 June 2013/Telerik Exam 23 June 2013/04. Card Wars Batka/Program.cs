using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Card_Wars_Batka
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfRounds = int.Parse(Console.ReadLine());
            string[] Player1Cards = new string[3];
            string[] Player2Cards = new string[3];
           double Player1Points = 0;
           double Player2Points = 0;
            double counterZCardP1 = 0;
            double counterZCardP2 = 0;
            double counterYCardP1 = 0;
            double counterYCardP2 = 0;
            bool player1HasXCard = false;
            bool player2HasXCard = false;
            int RoundScoreP1 = 0;
            int RoundScoreP2 = 0;
            int GamesWonByP1 = 0;
            int GamesWonByP2 = 0;
            bool XCardDrawn = false;
            for (int i = 0; i < amountOfRounds; i++)
            {
                //read cards
                #region ReadCards
                //player 1 cards
                for (int k = 0; k < Player1Cards.Length; k++)
                {
                    Player1Cards[k] = Console.ReadLine();
                }
                //player 2 cards
                for (int k = 0; k < Player1Cards.Length; k++)
                {
                    Player2Cards[k] = Console.ReadLine();
                }
                #endregion
                //check for special cards.
                //Big Cycle to calculate ROUND score.
                #region ReadCardsRole
                for (int k = 0; k < Player1Cards.Length; k++)
                {
                    if (Player1Cards[k] == "2")
                    {
                        RoundScoreP1 += 10;
                    }
                    if (Player1Cards[k] == "3")
                    {
                        RoundScoreP1 += 9;
                    }
                    if (Player1Cards[k] == "4")
                    {
                        RoundScoreP1 += 8;
                    }
                    if (Player1Cards[k] == "5")
                    {
                        RoundScoreP1 += 7;
                    }
                    if (Player1Cards[k] == "6")
                    {
                        RoundScoreP1 += 6;
                    }
                    if (Player1Cards[k] == "7")
                    {
                        RoundScoreP1 += 5;
                    }
                    if (Player1Cards[k] == "8")
                    {
                        RoundScoreP1 += 4;
                    }
                    if (Player1Cards[k] == "9")
                    {
                        RoundScoreP1 += 3;
                    }
                    if (Player1Cards[k] == "10")
                    {
                        RoundScoreP1 += 2;
                    }
                    if (Player1Cards[k] == "A")
                    {
                        RoundScoreP1 += 1;
                    }
                    if (Player1Cards[k] == "J")
                    {
                        RoundScoreP1 += 11;
                    }
                    if (Player1Cards[k] == "Q")
                    {
                        RoundScoreP1 += 12;
                    }
                    if (Player1Cards[k] == "K")
                    {
                        RoundScoreP1 += 13;
                    }
                    if (Player1Cards[k] == "Z")
                    {
                        counterZCardP1++;
                        Player1Points = Player1Points*Math.Pow(2.00, counterZCardP1);

                    }
                    if (Player1Cards[k] == "Y")
                    {
                        counterYCardP1 += 2;
                        Player1Points -= counterYCardP1 * 100;

                    }
                    if (Player1Cards[k] == "X")
                    {
                        player1HasXCard = true;
                    }
                }
                  //player 2
                for (int k = 0; k < Player2Cards.Length; k++)
                {
                    if (Player2Cards[k] == "2")
                    {
                        RoundScoreP2 += 10;
                    }
                    if (Player2Cards[k] == "3")
                    {
                        RoundScoreP2 += 9;
                    }
                    if (Player2Cards[k] == "4")
                    {
                        RoundScoreP2 += 8;
                    }
                    if (Player2Cards[k] == "5")
                    {
                        RoundScoreP2 += 7;
                    }
                    if (Player2Cards[k] == "6")
                    {
                        RoundScoreP2 += 6;
                    }
                    if (Player2Cards[k] == "7")
                    {
                        RoundScoreP2 += 5;
                    }
                    if (Player2Cards[k] == "8")
                    {
                        RoundScoreP2 += 4;
                    }
                    if (Player2Cards[k] == "9")
                    {
                        RoundScoreP2 += 3;
                    }
                    if (Player2Cards[k] == "10")
                    {
                        RoundScoreP2 += 2;
                    }
                    if (Player2Cards[k] == "A")
                    {
                        RoundScoreP2 += 1;
                    }
                    if (Player2Cards[k] == "J")
                    {
                        RoundScoreP2 += 11;
                    }
                    if (Player2Cards[k] == "Q")
                    {
                        RoundScoreP2 += 12;
                    }
                    if (Player2Cards[k] == "K")
                    {
                        RoundScoreP2 += 13;
                    }
                    if (Player2Cards[k] == "Z")
                    {
                        counterZCardP2++;
                        Player2Points = Player2Points * Math.Pow(2.00, counterZCardP2);

                    }
                    if (Player2Cards[k] == "Y")
                    {
                        counterYCardP2 += 2;
                        Player2Points -= counterYCardP2 * 100;

                    }
                    if (Player2Cards[k] == "X")
                    {
                        player2HasXCard = true;
                    }
                }
                #endregion
                //ok we got cards and round score.
                //now check for X Card.
                if (player1HasXCard || player2HasXCard)
                {
                    #region CheckXCard
                    if (player1HasXCard == true)
                    {
                        XCardDrawn = true;
                        if (player2HasXCard == true)
                        {
                            Player1Points += 50;
                            Player2Points += 50;
                        }
                        else
                        {
                            Console.WriteLine("X card drawn! Player one wins the match!");
                            Player1Points+=RoundScoreP1;
                        }
                    }
                    if (player2HasXCard == true)
                    {
                        XCardDrawn = true;
                        if (player1HasXCard == true)
                        {
                            Player1Points += 50;
                            Player2Points += 50;
                        }
                        else
                        {
                            Console.WriteLine("X card drawn! Player two wins the match!");
                            Player2Points+=RoundScoreP2;
                        }
                    }
                    #endregion
                }
                #region CalcMatchResult
                else
                {
                    if (RoundScoreP1 > RoundScoreP2)
                    {
                        Player1Points += RoundScoreP1;
                        GamesWonByP1++;

                    }
                    if (RoundScoreP2 > RoundScoreP1)
                    {
                        Player2Points += RoundScoreP2;
                        GamesWonByP2++;
                    }
                    if (RoundScoreP1 == RoundScoreP2)
                    {
                        
                    }
                }
                #endregion


                //clear variables
                
                #region ClearVariables
                counterZCardP1 = 0;
                counterZCardP2 = 0;
                counterYCardP1 = 0;
                counterYCardP2 = 0;
                player1HasXCard = false;
                player2HasXCard = false;
                RoundScoreP1 = 0;
                RoundScoreP2 = 0;
                #endregion
                    










            }
            if (XCardDrawn == false)
            {
                #region CalculateGameResult
                if (Player1Points > Player2Points)
                {
                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score: {0}", Player1Points);
                    Console.WriteLine("Games won: {0}", GamesWonByP1);
                }
                if (Player2Points > Player1Points)
                {
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score: {0}", Player2Points);
                    Console.WriteLine("Games won: {0}", GamesWonByP2);
                }
                if (Player1Points == Player2Points)
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine("Score: {0}", Player1Points);
                }

                #endregion
            }
        }
    }
}
