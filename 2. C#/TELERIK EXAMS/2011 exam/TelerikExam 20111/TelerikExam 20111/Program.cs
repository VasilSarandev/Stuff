using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikExam_20111
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenX = int.Parse(Console.ReadLine());
            int givenY = int.Parse(Console.ReadLine());
            // check if quadrant is 1 
            int quadrant = 0;
            if (givenX > 0 && givenY > 0)
            {
                quadrant = 1;
            }
            if (givenX > 0 && givenY < 0)
            {
                quadrant = 4;
            }
            if (givenX < 0 && givenY > 0)
            {
                quadrant = 2;
            }
            if (givenX < 0 && givenY < 0)
            {
                quadrant = 3;
            }
            if (givenY == 0 && givenX!=0)
            {
                quadrant = 6;
            }
            if (givenX == 0 && givenY!=0)
            {
                quadrant = 5;
            }
            if (givenX == 0 && givenY == 0)
            {
                quadrant = 0;
            }
            Console.Write(quadrant);
            
        }
    }
}
