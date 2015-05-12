using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Miss_Cat_2011
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Cats = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Cats[i] = i + 1;
                
            }

            int N = int.Parse(Console.ReadLine());
            int[] Votes = new int[N];
            for (int i = 1; i < N+1; i++)
            {
                Votes[i] = int.Parse(Console.ReadLine());
            }
            //now check votes.
            int MostFrequent = 0;
            int MostFrequentValue = 0;
            int CurrentFrequent = 0;
            int Counter=1;
            for (int i = 0; i < Votes.Length; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (Votes[i] == j)
                    {
                        CurrentFrequent++;
                    }
                    if (CurrentFrequent > MostFrequent)
                    {
                        MostFrequent = CurrentFrequent;
                        MostFrequentValue = j;
                    }
                }
            }
            Console.WriteLine(MostFrequentValue);

            
        }
    }
}
