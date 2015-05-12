using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigmation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            char[] InputSeparated = Input.ToCharArray();

            //deal with brackets.
            for (int i = 0; i < InputSeparated.Length; i++)
            {
                if (InputSeparated[i] == '(')
                {
                    for (int j = 0; j < InputSeparated.Length; j++)
                    {
                        if (InputSeparated[j] == ')')
                        {

                        }
                    }
                }
            }
        }
    }
}
