using System;
using System.Collections.Generic;
using System.Linq;

class Pairs
{
    static void Main()
    {
        string[] elementsSplit = Console.ReadLine().Split(' ');
        List<int> elements = new List<int>();

        foreach (string element in elementsSplit)
        {
            elements.Add(int.Parse(element));
        }

        List<int> values = new List<int>();
        List<int> differences = new List<int>() { 0 };
        int? sum = null;
        for (int i = 0; i < elements.Count; i += 2)
        {
            int currentSum = elements[i] + elements[i + 1];
            if (!sum.HasValue)
            {
                sum = currentSum;
            }

            values.Add(currentSum);
        }

        for (int i = 0; i < values.Count - 1; i++)
        {
            differences.Add(Math.Abs(values[i + 1] - values[i]));
        }

        int max = differences.Max();
        if (max == 0)
        {
            Console.WriteLine("Yes, value={0}", sum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", max);
        }
    }
}