using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Angry_Gangsta_Pisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //GPS
            //Gangsta Pisence
            string givenInteger = Console.ReadLine();
            long evenSum = 0;
            long oddSum = 0;
            string direction = "";
            for (int i = 0; i < givenInteger.Length; i++)
            {
                if ((givenInteger[i] - '0') % 2 == 0)
                {
                    evenSum += givenInteger[i] - '0';
                }
                else
                {
                    oddSum += givenInteger[i] - '0';
                }
            }
            long currentsum = 0;
            if (evenSum > oddSum)
            {
                direction = "right";
                currentsum = evenSum;
            }
            if (oddSum > evenSum)
            {
                direction = "left";
                currentsum = oddSum;
            }
            if (evenSum == oddSum)
            {
                direction = "straight";
                currentsum = oddSum;
            }
            
            Console.WriteLine("{0} {1}", direction, currentsum);
        }
    }
}
