using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_Exam_6_Dec_2013_Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            int IntegerA = int.Parse(Console.ReadLine());
            int SecretCode = int.Parse(Console.ReadLine());
            int IntegerC = int.Parse(Console.ReadLine());
            int result = 0;
            int PastResult = 0;
            if (SecretCode == 2)
            {
                result = IntegerA % IntegerC;
                PastResult = IntegerA % IntegerC; 
            }
            if (SecretCode == 4)
            {
                result = IntegerA + IntegerC;
                PastResult = IntegerA + IntegerC;
            }
            if (SecretCode == 8)
            {
                result = IntegerA * IntegerC;
            }
            if (result % 4 == 0)
            {
                result = result / 4;
            }
            else
            {
                result = result % 4;
            }
            Console.WriteLine(result);
            Console.WriteLine(PastResult);
        }
    }
}
