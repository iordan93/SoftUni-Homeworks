using System;
using System.Collections.Generic;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        Console.WriteLine("Enter the elements of the sequence, separated by spaces:");
        string[] elementsSplit = Console.ReadLine().Split(' ');
        int[] elements = new int[elementsSplit.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = int.Parse(elementsSplit[i]);
        }

        List<int> longestSequenceList = new List<int>();

        //Find the longest sequence of identical elements
        int longestSubsequenceStart = 0;
        int longestSubsequenceLength = 1;
        int currentSubsequenceLength = 1;

        for (int i = 0; i < elements.Length - 1; i++)
        {
            if (elements[i] == elements[i + 1])
            {
                currentSubsequenceLength++;

                if (currentSubsequenceLength > longestSubsequenceLength)
                {
                    longestSubsequenceLength = currentSubsequenceLength;
                    longestSubsequenceStart = i - longestSubsequenceLength + 2;
                }
            }
            else
            {
                currentSubsequenceLength = 1;
            }
        }

        for (int i = 0; i < longestSubsequenceLength; i++)
        {
            longestSequenceList.Add(elements[longestSubsequenceStart + i]);
        }

        // Algorithm to find combinations using bitwise operations
        long maxCombinations = (long)Math.Pow(2, elements.Length);
        for (long combination = 1; combination <= maxCombinations; combination++)
        {
            char[] binary = Convert.ToString(combination, 2).PadLeft(elements.Length, '0').ToCharArray();
            Array.Reverse(binary);
            string binaryReversed = new string(binary);

            List<int> current = new List<int>();
            int bitsCount = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (binaryReversed[i] == '1')
                {
                    current.Add(elements[i]);
                    bitsCount++;
                }
            }

            if (bitsCount < longestSequenceList.Count)
            {
                continue;
            }

            int currentLength = 0;
            List<int> currentLongestSubsequence = new List<int>();

            if (current.Count > 1)
            {
                int biggestNum = current[0];
                currentLongestSubsequence.Add(biggestNum);

                for (int i = 0; i < current.Count - 1; i++)
                {
                    if (current[i + 1] > biggestNum)
                    {
                        biggestNum = current[i + 1];

                        currentLongestSubsequence.Add(biggestNum);
                    }
                }

                currentLength = currentLongestSubsequence.Count;
            }

            if (currentLength > longestSequenceList.Count)
            {
                longestSequenceList = currentLongestSubsequence;
            }
        }

        for (int i = 0; i < longestSequenceList.Count; i++)
        {
            Console.Write(longestSequenceList[i] + " ");
        }
        Console.WriteLine();
    }
}