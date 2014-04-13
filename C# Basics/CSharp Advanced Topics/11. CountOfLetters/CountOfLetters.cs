using System;
using System.Collections.Generic;

class CountOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter the letters, separated by spaces:");
        string[] letters = Console.ReadLine().Split(' ');
        SortedDictionary<string, int> lettersCount = new SortedDictionary<string, int>();
        foreach (string letter in letters)
        {
            if (!lettersCount.ContainsKey(letter))
            {
                lettersCount[letter] = 1;
            }
            else
            {
                lettersCount[letter]++;
            }
        }

        foreach (var letter in lettersCount)
        {
            Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
        }
    }
}