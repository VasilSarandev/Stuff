using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Telerik_Exam_24_June_2013
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int Area = 250;
            int TomatoesAmount = int.Parse(Console.ReadLine());
            double TomatoArea = double.Parse(Console.ReadLine());
            double CucumberAmount = double.Parse(Console.ReadLine());
            double CucumberArea = double.Parse(Console.ReadLine());
            double PotatoAmount = double.Parse(Console.ReadLine());
            double PotatoArea = double.Parse(Console.ReadLine());
            double CarrotAmount = double.Parse(Console.ReadLine());
            double CarrotArea = double.Parse(Console.ReadLine());
            double CabbageAmount = double.Parse(Console.ReadLine());
            double CabageArea = double.Parse(Console.ReadLine());
            double BeansAmount = double.Parse(Console.ReadLine());
            int BeansArea =0;
            
            //prices
            double TotalCost = TomatoesAmount * 0.5 + CucumberAmount * 0.4 + PotatoAmount * 0.25 + CarrotAmount * 0.6 + CabbageAmount * 0.3 + BeansAmount * 0.4;
            Console.WriteLine("Total costs: {0:F2}", TotalCost);
            if (Area == TomatoArea + CucumberArea + PotatoArea + CarrotArea + CabageArea)
            {
                Console.WriteLine("No area for beans");
            }
            if (Area < TomatoArea + CucumberArea + PotatoArea + CarrotArea + CabageArea)
            {
                Console.WriteLine("Insufficient area");
            }
            if(Area>TomatoArea + CucumberArea + PotatoArea + CarrotArea + CabageArea)
            {
                Console.WriteLine("Beans area: {0}", Area - (TomatoArea + CucumberArea + PotatoArea + CarrotArea + CabageArea));
            }
            
            
        }
    }
}
