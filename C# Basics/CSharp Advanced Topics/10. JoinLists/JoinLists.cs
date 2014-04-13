using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Enter the first elements, separated by spaces:");
        string[] firstSplit = Console.ReadLine().Split(' ');
        Console.WriteLine("Enter the second elements, separated by spaces:");
        string[] secondSplit = Console.ReadLine().Split(' ');

        int[] firstElements = ConvertToIntArray(firstSplit);
        int[] secondElements = ConvertToIntArray(secondSplit);

        List<int> resultElements = new List<int>();
        resultElements.AddRange(firstElements);
        resultElements.AddRange(secondElements);
        resultElements = resultElements.Distinct().ToList();
        resultElements.Sort();

        Console.WriteLine(string.Join(" ", resultElements));
    }

    static int[] ConvertToIntArray(string[] elements)
    {
        int[] result = new int[elements.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = int.Parse(elements[i]);
        }

        return result;
    }
}