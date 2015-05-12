using System;


    class ComparisonByEps
    {
        static void Main()
        {
            double eps = 0.000001;
            double Comparee1a = 5.00000001;
            double Comparee1b = 5.00000003;
            double Comparee2a = 5.00000005;
            double Comparee2b = 5.00000001;
            float Comparee3a = 4.999999f;
            float Comparee3b = 4.999998f;

            if(Comparee1b-Comparee1a>eps){
                Console.WriteLine("The Numbers are not Equal with precision eps.");
            }
            else {
                Console.WriteLine("The Numbers are Equal with precision eps.");
            }
            if(Comparee2a-Comparee2b>eps){
                Console.WriteLine("The Numbers are not Equal with precision eps.");
            }
            else {
                Console.WriteLine("The Numbers are Equal with precision eps.");
            }
            if(Comparee3a-Comparee3b>eps){
                Console.WriteLine("The Numbers are not Equal with precision eps.");
            }
            else {
                Console.WriteLine("The Numbers are Equal with precision eps.");
            }
            Console.WriteLine("We do 3 comparisons to make sure the program is working correctly.");
            Console.WriteLine("First : {0} and {1}", Comparee1a, Comparee1b);
            Console.WriteLine("Second : {0} and {1}", Comparee2a, Comparee2b);
            Console.WriteLine("Third : {0} and {1}", Comparee3a, Comparee3b);

        }
    }

