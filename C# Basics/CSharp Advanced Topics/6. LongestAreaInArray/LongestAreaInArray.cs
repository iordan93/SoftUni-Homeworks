using System;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter n strings, each on a separate line:");

        string[] elements = new string[n];
        for (int i = 0; i < n; i++)
        {
            elements[i] = Console.ReadLine();
        }

        int currentStart = 0;
        int currentLength = 1;
        int longestSequenceStart = 0;
        int longestSequenceLength = 1;

        for (int index = 1; index < elements.Length; index++)
        {
            if (elements[index] == elements[index - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
                currentStart = index;
            }

            if (longestSequenceLength < currentLength)
            {
                longestSequenceLength = currentLength;
                longestSequenceStart = currentStart;
            }
        }

        Console.WriteLine(longestSequenceLength);
        for (int i = 0; i < longestSequenceLength; i++)
        {
            Console.WriteLine(elements[longestSequenceStart]);
        }
    }
}
