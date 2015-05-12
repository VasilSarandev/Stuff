using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggCelent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n;
            int width = 3 * n + 1;
            for (int r = 0; r < height; r++)
            {
                for (int c = 0; c < width; c++)
                {
                    if (c>n && c<2*n&&(r==0||r==height-1))
                    {
                        
                        Console.Write("*");
                    }
                    else if((r>=n/2 && r<2*n-n/2)&&(c==1  || c==width-2))
                    {
                        Console.Write("*");
                    }
                    else if(2*r-c==-(2*n-1) ||
                            2 * r - c == 3*n-3)
                    {
                        Console.Write("*");
                    }
                    else if (2*r+c==n+1||2*r+c==6*n-3)
                    {
                        Console.Write("*");
                    }
                    else if ((r==n-1 || r==n) && (c>1&&c<width-2) &&
                        (r+c)%2!=0)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
