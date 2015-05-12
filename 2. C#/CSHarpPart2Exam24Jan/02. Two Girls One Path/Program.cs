using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Two_Girls_One_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            int mollyIndex = 0;
            int dollyIndex = numbers.Length - 1;
            BigInteger mollyTotalFlowers = 0;
            BigInteger dollyTotalFlowers = 0;
            string winner = "";
            while (true)
            {
                if (numbers[mollyIndex] == 0 || numbers[dollyIndex] == 0)
                {
                    mollyTotalFlowers += numbers[mollyIndex];
                    dollyTotalFlowers += numbers[dollyIndex];
                    if (numbers[mollyIndex] == 0 && numbers[dollyIndex] == 0)
                    {
                        winner = "Draw";
                    }
                    else if (numbers[mollyIndex] == 0)
                    {
                        winner = "Dolly";
                    }
                    else if (numbers[dollyIndex] == 0)
                    {
                        winner = "Molly";
                    }
                    break;
                }
                BigInteger currentMollyFlowers = numbers[mollyIndex];
                BigInteger currentDollyFlowers = numbers[dollyIndex];
                //TODO : check if both are equal.

                numbers[mollyIndex] = 0;
                numbers[dollyIndex] = 0;


                mollyTotalFlowers += currentMollyFlowers;
                dollyTotalFlowers += currentDollyFlowers;

                mollyIndex = (int)((mollyIndex + currentMollyFlowers)%numbers.Length);
                dollyIndex = (int)((dollyIndex-currentDollyFlowers)%numbers.Length);
                if (dollyIndex < 0)
                {
                    dollyIndex += numbers.Length;
                }



               
            }
            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
        }
    }
}
