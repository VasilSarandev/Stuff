﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.IO;
using System.Media;

namespace TankWars
{
    struct Position
    {
        public int X;
        public int Y;
        public int CurrentDirectionBot;
        public Position(int X, int Y, int CurrentDirectionBot)
        {
            this.X = X;
            this.Y = Y;
            this.CurrentDirectionBot = CurrentDirectionBot;
        }
    }

    class Program
    {
        static int matrixHeight, matrixWidth;
        static int botsCount = 4;
        static Random randomIntGenerator = new Random();
        static Position[] directions = GetDirections();

        static void Main()
        {
            string[] botsSymbols = new string[]
            {
                "" +(char)16,   // right
                "" +(char)17,   // left
                "" +(char)30,   // up
                "" +(char)31,   // down
            };

            int score = 0;
            int currentBoardNumber = 1;                         // initialized for board No.1
            int[,] board = LoadBoard(currentBoardNumber);       // Load 1st board from file board1.txt
            int lives = 3;
            matrixHeight = board.GetLength(0);
            matrixWidth = board.GetLength(1);
            Console.CursorVisible = false;

            Console.BufferHeight = Console.WindowHeight;
            DrawConsoleLayout();
            string printBoard = PrintBoard(board);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(printBoard);
            Position player = InitializePlayer();
            List<Position> bots = GenerateBots(board);
            Position target = GenerateTarget(board);

            DrawBots(bots, botsSymbols);
            bool gamerunning = true;

            while (gamerunning)
            {
                ClearConsole(player, target, bots);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(printBoard);
                bool targetAcquired = false;

                if (Console.KeyAvailable)
                {
                    player = MovePlayer(player, board);
                }

                bots = MoveBotsPosition(bots, board);
                targetAcquired = IsTargetAcquired(player, target);

                if (targetAcquired)
                {
                    target = GenerateTarget(board);
                    score++;
                }

                DrawPlayer(player);
                DrawPlayerInfo(score, lives);
                DrawTarget(target);
                DrawBots(bots, botsSymbols);

                Thread.Sleep(200);
                //check if dead.
                gamerunning = CheckIfBotHitPlayer(bots, player, score);

                if (!gamerunning)
                {
                    lives--;
                    if (lives > 0)
                    {
                        ClearConsole(player, target, bots);
                        player = InitializePlayer();
                        bots = GenerateBots(board);
                        gamerunning = true;
                    }
                    else
                    {
                        SoundPlayer endGame = PlaySound("boss");
                        DrawEndScreen(score);
                        Highscores(score);
                    }
                }
                // if (currentLive < previousLive)
                //  {
                //      player = InitializePlayer();
                //      bots = GenerateBots();
                //      target = GenerateTarget();
                //  }

            }
        }

        static void ClearConsole(Position player, Position target, List<Position> bots)
        {
            Console.SetCursorPosition(player.Y, player.X);
            Console.Write(" ");
            Console.SetCursorPosition(50, 10);
            Console.Write(" ");
            Console.SetCursorPosition(target.Y, target.X);
            Console.Write(" ");
            Console.Clear();
        }

        static void DrawEndScreen(int score)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = Encoding.ASCII;
            string path = "../../Screens/GameOverScreen.txt";
            StreamReader reader = new StreamReader(path);
            string text = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(text);
            Console.SetCursorPosition(15, 15);
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Your score is ... {0} ", score);
        }

        static void DrawBossScreen()                    // this method should be called just before Boss fight starts
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            StringBuilder sbBoss = new StringBuilder();
            sbBoss.Append("\n\n\n\n\n\n\n\n");
            sbBoss.Append("\t" + @"  ____   ____   _____ _____   ______ _____ _____ _    _ _______ " + "\n");
            sbBoss.Append("\t" + @" |  _ \ / __ \ / ____/ ____| |  ____|_   _/ ____| |  | |__   __|" + "\n");
            sbBoss.Append("\t" + @" | |_) | |  | | (___| (___   | |__    | || |  __| |__| |  | |   " + "\n");
            sbBoss.Append("\t" + @" |  _ <| |  | |\___ \\___ \  |  __|   | || | |_ |  __  |  | |   " + "\n");
            sbBoss.Append("\t" + @" | |_) | |__| |____) |___) | | |     _| || |__| | |  | |  | |   " + "\n");
            sbBoss.Append("\t" + @" |____/ \____/ \____/\____/  |_|    |_____\_____|_|  |_|  |_|   " + "\n");

            Console.WriteLine(sbBoss);
        }



        static Position InitializePlayer()
        {
            Position player = new Position(1, 1, 0);
            Console.SetCursorPosition(player.Y, player.X);
            Console.Write("" + (char)1);

            return player;
        }

        static Position MovePlayer(Position player, int[,] board)
        {
            int direction = 0;

            ConsoleKeyInfo userInput = Console.ReadKey();
            if (userInput.Key == ConsoleKey.RightArrow)
            {
                direction = 0;
            }
            else if (userInput.Key == ConsoleKey.LeftArrow)
            {
                direction = 1;
            }
            else if (userInput.Key == ConsoleKey.UpArrow)
            {
                direction = 2;
            }
            else
            {
                direction = 3;
            }

            if (board[player.X + directions[direction].X, player.Y + directions[direction].Y] != 1)
            {
                player = new Position(player.X + directions[direction].X, player.Y + directions[direction].Y, 0);
            }

            return player;
        }

        static List<Position> MoveBotsPosition(List<Position> bots, int[,] board)
        {
            int randomDirection = 0;
            int currCordinateX = 0;
            int currCordinateY = 0;
            int currDirection = 0;
            bool CorrectDirection = false;
            int nextPosX = 0;
            int nextPosY = 0;

            List<Position> CopyBots = new List<Position>(bots);
            bots.Clear();

            for (int i = 0; i < botsCount; i++)
            {
                randomDirection = CopyBots[i].CurrentDirectionBot;
                nextPosX = CopyBots[i].X + directions[randomDirection].X;
                nextPosY = CopyBots[i].Y + directions[randomDirection].Y;
                currCordinateX = CopyBots[i].X;
                currCordinateY = CopyBots[i].Y;
                CorrectDirection = false;

                if (board[nextPosX, nextPosY] == 1)
                {
                    CorrectDirection = false;
                    while (CorrectDirection == false)
                    {
                        currDirection = randomIntGenerator.Next(0, 4);
                        if (currDirection != randomDirection &&
                            board[currCordinateX + directions[currDirection].X, currCordinateY + directions[currDirection].Y] == 0)
                        {
                            CorrectDirection = true;
                            CopyBots[i] = new Position(currCordinateX, currCordinateY, currDirection);
                        }
                    }
                }
                else
                {
                    CorrectDirection = true;
                }
            }

            if (CorrectDirection)
            {
                for (int i = 0; i < botsCount; i++)
                {
                    randomDirection = CopyBots[i].CurrentDirectionBot;
                    bots.Add(new Position(CopyBots[i].X + directions[randomDirection].X, CopyBots[i].Y + directions[randomDirection].Y, randomDirection));
                }

            }
            return bots;
        }

        static Position[] GetDirections()
        {
            Position[] directions = new Position[] 
            {
                 new Position(0,1,0),    //right
                 new Position(0,-1,0),   //left
                 new Position(-1,0,0),   //up
                 new Position(1,0, 0)    //down
            };

            return directions;
        }

        static List<Position> GenerateBots(int[,] board)
        {
            List<Position> bots = new List<Position>();
            bool AllRightPosition;
            for (int i = 0; i < botsCount; i++)
            {
                AllRightPosition = false;
                int randomX = randomIntGenerator.Next(1, matrixHeight - 1);
                int randomY = randomIntGenerator.Next(1, matrixWidth - 1);
                while (AllRightPosition == false)
                {
                    randomY = randomIntGenerator.Next(1, matrixWidth - 1);
                    randomX = randomIntGenerator.Next(1, matrixHeight - 1);
                    if (board[randomX, randomY] == 0)
                    {
                        AllRightPosition = true;
                    }
                }
                bots.Add(new Position(randomX, randomY, randomIntGenerator.Next(0, 4)));
            }

            return bots;
        }

        static Position GenerateTarget(int[,] board)
        {
            Position target = new Position();
            while (true)
            {
                target = new Position(randomIntGenerator.Next(5, matrixHeight - 5), randomIntGenerator.Next(4, matrixWidth - 4), 0);
                if (board[target.X, target.Y] == 0)
                {
                    break;
                }
            }

            return target;
        }

        static void DrawBots(List<Position> bots, string[] botsSymbols)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < bots.Count; i++)
            {
                //set symbol according to direction.
                // X,Y,Z x,y coordinate Z currentdirection 0,1,2,3 4 < > ^ 

                Console.SetCursorPosition(bots[i].Y, bots[i].X);
                Console.Write(botsSymbols[bots[i].CurrentDirectionBot]);
            }
        }

        static void DrawConsoleLayout()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DrawPlayer(Position player)
        {
            Console.SetCursorPosition(player.Y, player.X);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("" + (char)2);
        }

        static void DrawPlayerInfo(int score, int lives)
        {
            Console.SetCursorPosition(50, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Your score is ... : {0}", score);
            Console.SetCursorPosition(50, 11);
            Console.Write("Lives: {0} x {1}", lives, (char)3);
        }

        static void DrawTarget(Position target)
        {
            Console.SetCursorPosition(target.Y, target.X);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write((char)3);
        }

        static bool CheckIfBotHitPlayer(List<Position> bots, Position player, int score)
        {
            bool gamerunning = true;

            for (int i = 0; i < bots.Count; i++)
            {
                if (bots[i].X == player.X && bots[i].Y == player.Y)
                {
                    gamerunning = false;
                    SoundPlayer gotCha = PlaySound("death");
                    return gamerunning;
                }
            }

            return gamerunning;
        }

        static bool IsTargetAcquired(Position player, Position target)
        {
            bool targetAcquired = false;
            if (player.X == target.X && player.Y == target.Y)
            {
                targetAcquired = true;
                SoundPlayer eatTarget = PlaySound("eattarget");
            }

            return targetAcquired;
        }

        // maze
        static int[,] LoadBoard(int currentBoardNumber)     // This method can call any of the preset 3 boards, each in separate file, respectively named board1.txt, board2.txt and board3.txt
        {
            string path = "../../Boards/board" + currentBoardNumber + ".txt";
            StreamReader reader = new StreamReader(path);

            using (reader)
            {
                int rows = int.Parse(reader.ReadLine());
                string line = reader.ReadLine();
                int[,] boardToLoad = new int[rows, line.Length];
                int lineNumber = 0;

                while (line != null)
                {
                    for (int j = 0; j < line.Length; j++) boardToLoad[lineNumber, j] = (line[j]) - '0';
                    lineNumber++;
                    line = reader.ReadLine();
                }

                return boardToLoad;
            }
        }

        static string PrintBoard(int[,] board)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    sb.Append(board[i, j] == 1 ? ((char)2).ToString() : " ");    // 1's => Walls -> not allowed to go through | 0's -> maze path free to go through
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }

        static SoundPlayer PlaySound(string soundName)
        {
            SoundPlayer player = new SoundPlayer("../../Sounds/" + soundName + ".wav");
            player.Play();

            return player;
        }

        static void StopSound(SoundPlayer player)
        {
            player.Stop();
        }
        static void Highscores(int score)
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Enter your name!");
            string name = Console.ReadLine();
            Console.Clear();
            List<string> names = new List<string>();
            List<int> scores = new List<int>();
            using (StreamReader ReadFile = new StreamReader("..//..//..//Highscore.txt"))       //Extracting the data from the text file
            {
                int CurrentLine = 1;
                string TextLine = "";
                while ((TextLine = ReadFile.ReadLine()) != null)
                {
                    if (CurrentLine % 2 == 1)
                    {
                        names.Add(TextLine);
                        CurrentLine++;
                    }
                    else if (CurrentLine % 2 == 0)
                    {
                        int number = int.Parse(TextLine);
                        scores.Add(number);
                        CurrentLine++;
                    }
                }
            }
            names.Add(name);                                //Add the currently achieved score
            scores.Add(score);
            for (int i = 0; i < scores.Count; i++)          //Selection Sort
            {
                string TempName = "";
                int TempScore = 0;
                int min = 0;
                min = i;
                for (int j = i + 1; j < scores.Count; j++)
                {
                    if (scores[j] < scores[min])
                    {
                        min = j;
                    }
                }
                TempScore = scores[min];
                TempName = names[min];
                scores[min] = scores[i];
                names[min] = names[i];
                scores[i] = TempScore;
                names[i] = TempName;                        //Selection Sort
            }
            scores.Reverse();                               //Reversing the Lists in Descending order
            names.Reverse();
            scores.RemoveAt(scores.Count - 1);              //Removing the Last element (Lowest score)
            names.RemoveAt(names.Count - 1);
            using (StreamWriter WriteFile = new StreamWriter("..//..//..//Highscore.txt"))     //Writing the new Highscore table to the same file!
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    WriteFile.WriteLine(names[i]);
                    WriteFile.WriteLine(scores[i]);
                }
            }
            string str1 = "Name";
            string str2 = "Score";
            Console.WriteLine("\n Highscores!\n {0}", new string('-', 24));
            Console.WriteLine(" |{0,13}{1,8} |\n {2}", str1, str2, new string('-', 24));
            for (int i = 0, line = 1; i < 9; i++, line++)
            {
                Console.WriteLine(" | {0}.{1,10}{2,8} |", line, names[i], scores[i]);
            }
            Console.WriteLine(" | 10.{0,9}{1,8} |\n {2}", names[9], scores[9], new string('-', 24));
        }
    }
}