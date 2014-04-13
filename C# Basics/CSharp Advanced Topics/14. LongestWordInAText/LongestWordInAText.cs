using System;
using System.Text.RegularExpressions;

class LongestWordInAText
{
    static void Main()
    {
        Console.Write("Enter the text: ");
        string text = Console.ReadLine();
        string[] words = Regex.Split(text, @"\W");

        int longestIndex = 0;
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > words[longestIndex].Length)
            {
                longestIndex = i;
            }
        }

        Console.WriteLine("The longest word is: {0}", words[longestIndex]);
    }
}