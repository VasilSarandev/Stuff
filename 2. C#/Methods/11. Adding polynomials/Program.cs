using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            string Polynomal1 = "x2 + 4x + 5";
            string Polynomal2 = "x2 + 3x + 4";
            Console.WriteLine("Polynomal 1 is ... {0}", Polynomal1);
            Console.WriteLine("Polynomal 2 iss ... {0}", Polynomal2);
            SubstractPolynomals(Polynomal1, Polynomal2);
        }
        static void SubstractPolynomals(string Polynomal1, string Polynomal2)
        {
            string[] ArrayPoly1 = Polynomal1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] ArrayPoly2 = Polynomal2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] Array1 = new int[3];
            int[] Array2 = new int[3];
            int counter = 0;
            int value =0 ;
            for (int i = 0; i < ArrayPoly1.Length; i++)
            {
                bool result = Int32.TryParse(ArrayPoly1[i], out value);
                if (result)
                {
                    Array1[counter] = int.Parse(ArrayPoly1[i]);
                    counter++;
                }
                else
                {
                    
                }
            }
            
            for (int i = 0; i < ArrayPoly2.Length; i++)
            {
                bool result = Int32.TryParse(ArrayPoly2[i], out value);
                if (result)
                {
                    Array2[counter] = int.Parse(ArrayPoly2[i]);
                    counter++;
                }
                else
                {

                }
            }
            int[] ResultArray = new int[3];
            ResultArray[0] = Array1[0] + Array2[0];
            ResultArray[1] = Array1[1] + Array2[1];
            ResultArray[2] = Array1[2] + Array2[2];
            Console.WriteLine("Result polynomal ... : {0}x2 + {1}x + {2}", ResultArray[0], ResultArray[1], ResultArray[2]);
        }
    }
}
