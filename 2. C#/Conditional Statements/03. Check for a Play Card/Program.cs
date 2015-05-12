using System;
/*Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
 * Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
 * 
 * 
 * 
 * */

//string[] GivenNumbersSeparated = GivenNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    class PlayCard
    {
        static void Main()
        {
            string ValidDigits = "2 3 4 5 6 7 8 9 10 J Q K A";
            string[] ValidCards = ValidDigits.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Please give me a string to check if valid card sign.");
            string CheckIfValid = Console.ReadLine();
            bool Valid = false;
            for (int i = 0; i < ValidCards.Length; i++)
            {
                if (CheckIfValid == ValidCards[i])
                {
                    Valid = true;
                }
            }
            if (Valid)
            {
                Console.WriteLine("The string you've given me is a valid card sign.");
            }
            else
            {
                Console.WriteLine("The string is NOT a valid card sign.");
            }
        }
    }

