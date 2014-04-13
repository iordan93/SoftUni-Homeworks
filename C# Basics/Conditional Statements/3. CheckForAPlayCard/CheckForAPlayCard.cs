using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter the string to be checked: ");

        // Trim() removes all spaces before and after the input. It is generally a good idea to use when checking strings
        string cardFace = Console.ReadLine().Trim();
        if (cardFace == "2" ||
            cardFace == "3" ||
            cardFace == "4" ||
            cardFace == "5" ||
            cardFace == "6" ||
            cardFace == "7" ||
            cardFace == "8" ||
            cardFace == "9" ||
            cardFace == "10" ||
            cardFace == "J" ||
            cardFace == "Q" ||
            cardFace == "K" ||
            cardFace == "A")
        {
            Console.WriteLine("Valid card sign");
        }
        else 
        {
            Console.WriteLine("Invalid card sign");
        }
    }
}