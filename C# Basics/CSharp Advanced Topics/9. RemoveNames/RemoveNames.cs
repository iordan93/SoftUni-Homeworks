using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Enter all names, separated by spaces:");
        string[] names = Console.ReadLine().Split(' ');
        Console.WriteLine("Enter the names to remove, separated by spaces:");
        string[] namesToRemove = Console.ReadLine().Split(' ');

        List<string> resultNames = new List<string>();
        resultNames = names
            .Where(name => !namesToRemove.Contains(name))
            .ToList();

        Console.WriteLine(string.Join(" ", resultNames));
    }
}