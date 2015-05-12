using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int x = 5;
        int y = 7;

        sum += CheckIfOne(sum, x, y);
    }
    private static int CheckIfOne(int sum, int x, int y)
    {
        if (x < 0 || x > 15 ||
            y < 0 || y > 15)
        {
            return 0;
        }
        return 1;
    }
}

/*
                        if(tray[QuestionnedPosition.Y][QuestionnedPosition.X]=='1')
                        {
                            sum++;
                        }

                            if(tray[QuestionnedPosition.Y-1][QuestionnedPosition.X-1]=='1')
                            {
                                sum++;
                            }
                        
                        if(tray[QuestionnedPosition.Y-1][QuestionnedPosition.X]=='1')
                        {
                            sum++;
                        }
                            if(tray[QuestionnedPosition.Y - 1][QuestionnedPosition.X+1]=='1')
                            {
                                sum++;
                            }
                            if(tray[QuestionnedPosition.Y][QuestionnedPosition.X-1]=='1')
                            {
                                sum++;
                            }

                            if(tray[QuestionnedPosition.Y][QuestionnedPosition.X+1]=='1')
                            {
                                sum++;
                            }
                            if(tray[QuestionnedPosition.Y+1][QuestionnedPosition.X-1]=='1')
                            {
                                sum++;
                            }

                            if(tray[QuestionnedPosition.Y + 1][QuestionnedPosition.X] =='1')
                            {
                                sum++;
                            }

                            if (tray[QuestionnedPosition.Y + 1][QuestionnedPosition.X + 1] == '1')
                            {
                                sum++;
                            }
                         */
