using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.Subset_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger Sum = BigInteger.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            long[] IntegersArray = new long[N];
            int sumCounter = 0;
            for (int i = 0; i < N; i++)
            {
                IntegersArray[i] = long.Parse(Console.ReadLine());
            }
            //check if any member of array is equal to sum.
            for (int i = 0; i < IntegersArray.Length; i++)
            {
                if (IntegersArray[i] == Sum)
                {
                    sumCounter++;
                }
            }
            //check if there are any subsets now.
            for (int i = 0; i < IntegersArray.Length; i++)
            {
                for (int j = 0; j < IntegersArray.Length; j++)
                {
                    if (IntegersArray[i] + IntegersArray[j] == Sum)
                    {
                        sumCounter++; //2
                    }
                    for (int k = 0; k < IntegersArray.Length; k++)
                    {
                        if (IntegersArray[i] + IntegersArray[j] + IntegersArray[k] == Sum)
                        {
                            sumCounter++; //3
                        }
                        for (int l = 0; l < IntegersArray.Length; l++)
                        {
                            if (IntegersArray[i] + IntegersArray[j] + IntegersArray[k] + IntegersArray[l] == Sum)
                            {
                                sumCounter++; //4
                            }
                            for (int p = 0; p < IntegersArray.Length; p++)
                            {
                                if (IntegersArray[i] + IntegersArray[j] + IntegersArray[k] + IntegersArray[l] + IntegersArray[p] == Sum)
                                {
                                    sumCounter++; //5
                                }
                                for (int u = 0; u < IntegersArray.Length; u++)
                                {
                                    if (IntegersArray[i] + IntegersArray[j] + IntegersArray[k] + IntegersArray[l] + IntegersArray[p] + IntegersArray[u] == Sum)
                                    {
                                        sumCounter++; //6
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.Write(sumCounter);
        }
    }
}
