using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        Console.WriteLine("Enter the names, separated by spaces:");
        string[] names = Console.ReadLine().Split(' ');
        SortedDictionary<string, int> namesCount = new SortedDictionary<string, int>();
        foreach (string name in names)
        {
            if (!namesCount.ContainsKey(name))
            {
                namesCount[name] = 1;
            }
            else
            {
                namesCount[name]++;
            }
        }

        foreach (var name in namesCount)
        {
            Console.WriteLine("{0} -> {1}", name.Key, name.Value);
        }
    }
}