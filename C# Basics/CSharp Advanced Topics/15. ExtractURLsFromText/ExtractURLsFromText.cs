using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.Write("Enter the text:");
        string text = Console.ReadLine();

        List<string> urls = new List<string>();
        foreach (Match match in Regex.Matches(text, @"(http\:\/\/|www.)[A-Za-z0-9\.\-]*", RegexOptions.IgnoreCase))
        {
            // The regular expression matches trailing dots too. This removes them from the output
            if (match.Value.EndsWith("."))
            {
                urls.Add(match.Value.Substring(0, match.Value.Length - 1));
            }
            else
            {
                urls.Add(match.Value);
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, urls));
    }
}