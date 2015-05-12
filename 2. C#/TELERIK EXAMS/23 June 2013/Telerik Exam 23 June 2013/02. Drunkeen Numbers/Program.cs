using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Drunkeen_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long MitkoBeers = 0;
            long VladkoBeers = 0;
            for (int i = 0; i < n; i++)

            {
                long roundInfo = long.Parse(Console.ReadLine());
                if (roundInfo < 0)
                {
                    roundInfo = -roundInfo;
                }
                int digits = 0;
                long tempRoundInfo = roundInfo;
                while (tempRoundInfo > 0)
                {
                    tempRoundInfo /= 10;
                    digits++;
                }
                if (digits % 2 == 0)
                {
                    for (int j = 0; j < digits / 2; j++) 
                    {
                        VladkoBeers += roundInfo % 10;
                        roundInfo /= 10;
                    }
                    for (int j = 0; j < digits / 2; j++)
                    {
                        MitkoBeers += roundInfo % 10;
                        roundInfo /= 10;
                    }
                    //m-->first half
                    //v-->second half
                }
                else
                {
                    for (int j = 0; j < digits / 2; j++)
                    {
                        VladkoBeers += roundInfo % 10;
                        roundInfo /= 10;
                    }
                    long middle = roundInfo % 10;
                    VladkoBeers += middle;
                    MitkoBeers += middle;
                    roundInfo /= 10;

                    for (int j = 0; j < digits / 2; j++)
                    {
                        MitkoBeers += roundInfo % 10;
                        roundInfo /= 10;
                    }

                   
                    //m---> first half + middle number
                    //v---> second half + middle number
                }
            }
            if (MitkoBeers > VladkoBeers)
            {
                Console.WriteLine("M {0}", MitkoBeers - VladkoBeers);
            }
            else if (VladkoBeers > MitkoBeers)
            {
                Console.WriteLine("V {0}", VladkoBeers - MitkoBeers);
            }
            else //m=v
            {
                Console.WriteLine("No {0}", MitkoBeers + VladkoBeers);
            }
        }
    }
}
