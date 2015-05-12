using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Telerik_Exam_23_June_2013
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int coinsInTray1 = int.Parse(Console.ReadLine());
            int coinsInTray2 = int.Parse(Console.ReadLine());
            int coinsInTray3 = int.Parse(Console.ReadLine());
            int coinsInTray4 = int.Parse(Console.ReadLine());
            int coinsInTray5 = int.Parse(Console.ReadLine());
            double amountInTray1 = coinsInTray1 * 0.05;
            double amountInTray2 = coinsInTray2 * 0.10;
            double amountInTray3 = coinsInTray3 * 0.20;
            double amountInTray4 = coinsInTray4 * 0.50;
            double amountInTray5 = coinsInTray5 * 1.00;
            double TotalAmount = amountInTray1+amountInTray2+amountInTray3+amountInTray4+amountInTray5;
            double givenCash = double.Parse(Console.ReadLine());
            double priceOfDrink = double.Parse(Console.ReadLine());
            //print according to situation.

            if (givenCash > priceOfDrink && givenCash - priceOfDrink < TotalAmount || givenCash==priceOfDrink)
            {
                Console.WriteLine("Yes {0:0.00}", TotalAmount - givenCash + priceOfDrink);
            }
            if (givenCash<priceOfDrink)
            {
                Console.WriteLine("More {0:0.00}", priceOfDrink - givenCash);
            }
            if (givenCash > priceOfDrink && givenCash - priceOfDrink > TotalAmount)
            {
                Console.WriteLine("No {0:0.00}", givenCash - priceOfDrink - TotalAmount);
            }
 
        }
    }
}
