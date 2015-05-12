using System;
//Print the first 10 numbers of the sequence 2, -3, 4, -5, 6, -7...


    class PrintingSequence
    {
        static void Main()
        {
            byte Counter =0;
            for (var i = 2  ; i < 12; i++)
            {
                if (Counter % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
                Counter++;
            }
        }
    }

