using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sheets
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenInteger = int.Parse(Console.ReadLine());
            int indexOfSheet = 0;
            double[] Sheets = new double[11];
            bool ExactValue = false;
            for (int i = 0; i < Sheets.Length; i++)
            {
                Sheets[i] = Math.Pow(2, i);
            }
            //get index of the maximum sheet which is smaller than desired num.
            for (int i = 0; i < Sheets.Length; i++)
            {
                if (Sheets[i] == givenInteger)
                {
                    indexOfSheet = i;
                    ExactValue = true;
                    break;
                }
                if (Sheets[i] > givenInteger)
                {
                    indexOfSheet = i-1;
                    break;
                    
                }
            }
            //calculate shiet now.
            if (ExactValue)
            {
                int counter = 0;
                var SheetsList = Sheets.ToList();
                SheetsList.Remove(Sheets[indexOfSheet]);
                double[] newSheetArray = new double[10];
                newSheetArray = SheetsList.ToArray();
                string[] NewArray = new string[10];
                for (int i = 0; i < newSheetArray.Length; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (newSheetArray[i] == Math.Pow(2, j))
                        {
                            string suffix = j.ToString();
                            if (suffix == "10")
                            {
                                suffix = "0";
                            }
                            NewArray[counter] = "A" + suffix; 
                            counter++;
                        }
                    }
                }
                
                foreach (string shiet in NewArray)
                {
                    Console.WriteLine(shiet);
                }
            }


        }
    }
}
