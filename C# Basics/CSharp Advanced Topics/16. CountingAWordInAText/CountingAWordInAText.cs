using System;
using System.Text.RegularExpressions;

class CountingAWordInAText
{
    static void Main()
    {
        Console.Write("Enter the keyword to count: ");
        string keyword = Console.ReadLine();
        Console.Write("Enter the text: ");
        string text = Console.ReadLine();

        string[] words = Regex.Split(text, @"\W");

        int wordCount = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].ToLower().Equals(keyword.ToLower()))
            {
                wordCount++;   
            }
        }

        Console.WriteLine(wordCount);
    }
}