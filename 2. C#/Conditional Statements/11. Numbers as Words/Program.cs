using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.


class NumbersAsWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please give me an integer so i can tell you the English pronunciation.");
        int GivenInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Processing....");
        if (GivenInteger >= 0 & GivenInteger <= 999)
        {
            switch (GivenInteger)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                case 10: Console.WriteLine("Ten"); break;
                case 11: Console.WriteLine("Eleven"); break;
                case 12: Console.WriteLine("Twelve"); break;
                case 13: Console.WriteLine("Thirteen"); break;
                case 14: Console.WriteLine("Fourteen"); break;
                case 15: Console.WriteLine("Fifteen"); break;
                case 16: Console.WriteLine("Sixteen"); break;
                case 17: Console.WriteLine("Seventeen"); break;
                case 18: Console.WriteLine("Eighteen"); break;
                case 19: Console.WriteLine("Nineteen"); break;
                case 20: Console.WriteLine("Twenty"); break;

            }
            if (GivenInteger > 20 & GivenInteger < 100)
            {
                int LastDigit = GivenInteger % 10;
                int FirstDigit = GivenInteger / 10;
                string FirstPart = "";
                string SecondPart = "";
                string WholePronunciation = "";
                switch (FirstDigit)
                {
                    case 2: FirstPart = "Twenty"; break;
                    case 3: FirstPart = "Thirty"; break;
                    case 4: FirstPart = "Forty"; break;
                    case 5: FirstPart = "Fifty"; break;
                    case 6: FirstPart = "Sixty"; break;
                    case 7: FirstPart = "Seventy"; break;
                    case 8: FirstPart = "Eighty"; break;
                    case 9: FirstPart = "Ninety"; break;
                }
                switch (LastDigit)
                {
                    case 0: SecondPart = ""; break;
                    case 1: SecondPart = "One"; break;
                    case 2: SecondPart = "Two"; break;
                    case 3: SecondPart = "Three"; break;
                    case 4: SecondPart = "Four"; break;
                    case 5: SecondPart = "Five"; break;
                    case 6: SecondPart = "Six"; break;
                    case 7: SecondPart = "Seven"; break;
                    case 8: SecondPart = "Eight"; break;
                    case 9: SecondPart = "Nine"; break;
                }
                WholePronunciation = FirstPart + " " + SecondPart;
                Console.WriteLine(WholePronunciation);

            }
            if (GivenInteger > 99 & GivenInteger < 1000)
            {
                int FirstDigit = GivenInteger / 100;
                int SecondDigit = GivenInteger / 10;
                SecondDigit = SecondDigit % 10;
                int ThirdDigit = GivenInteger % 100;
                ThirdDigit = ThirdDigit % 10;
                string FirstPart = "";
                string SecondPart = "";
                string ThirdPart = "";
                string WholePronunciationn = "";
                if (SecondDigit == 1)
                {
                    string Pronunciation = "";
                    string FirsttPart = "";
                    string SeconddPart = "";
                    switch (ThirdDigit)
                    {
                        case 0: SeconddPart = "ten"; break;
                        case 1: SeconddPart = "Eleven"; break;
                        case 2: SeconddPart = "Twelve"; break;
                        case 3: SeconddPart = "Thirteen"; break;
                        case 4: SeconddPart = "Fourteen"; break;
                        case 5: SeconddPart = "Fifteen"; break;
                        case 6: SeconddPart = "Sixteen"; break;
                        case 7: SeconddPart = "Seventeen"; break;
                        case 8: SeconddPart = "Eighteen"; break;
                        case 9: SeconddPart = "Nineteen"; break;

                    }
                    switch (FirstDigit)
                    {
                        case 1: FirsttPart = "One"; break;
                        case 2: FirsttPart = "Two"; break;
                        case 3: FirsttPart = "Three"; break;
                        case 4: FirsttPart = "Four"; break;
                        case 5: FirsttPart = "Five"; break;
                        case 6: FirsttPart = "Six"; break;
                        case 7: FirsttPart = "Seven"; break;
                        case 8: FirsttPart = "Eight"; break;
                        case 9: FirsttPart = "Nine"; break;
                    }
                    Pronunciation = FirsttPart + " hundred and " + SeconddPart;
                    Console.WriteLine(Pronunciation);
                }
                else
                {
                    switch (FirstDigit)
                    {
                        case 1: FirstPart = "One"; break;
                        case 2: FirstPart = "Two"; break;
                        case 3: FirstPart = "Three"; break;
                        case 4: FirstPart = "Four"; break;
                        case 5: FirstPart = "Five"; break;
                        case 6: FirstPart = "Six"; break;
                        case 7: FirstPart = "Seven"; break;
                        case 8: FirstPart = "Eight"; break;
                        case 9: FirstPart = "Nine"; break;
                    }

                    switch (SecondDigit)
                    {
                        case 0: SecondPart = ""; break;
                        case 2: SecondPart = "Twenty"; break;
                        case 3: SecondPart = "Thirty"; break;
                        case 4: SecondPart = "Forty"; break;
                        case 5: SecondPart = "Fifty"; break;
                        case 6: SecondPart = "Sixty"; break;
                        case 7: SecondPart = "Seventy"; break;
                        case 8: SecondPart = "Eighty"; break;
                        case 9: SecondPart = "Ninety"; break;
                    }
                    switch (ThirdDigit)
                    {
                        case 1: ThirdPart = "One"; break;
                        case 2: ThirdPart = "Two"; break;
                        case 3: ThirdPart = "Three"; break;
                        case 4: ThirdPart = "Four"; break;
                        case 5: ThirdPart = "Five"; break;
                        case 6: ThirdPart = "Six"; break;
                        case 7: ThirdPart = "Seven"; break;
                        case 8: ThirdPart = "Eight"; break;
                        case 9: ThirdPart = "Nine"; break;
                    }

                    WholePronunciationn = FirstPart + " " + "hundred" + " and " + SecondPart + " " + ThirdPart;
                    Console.WriteLine(WholePronunciationn);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid Input.");
        }
    }
}
