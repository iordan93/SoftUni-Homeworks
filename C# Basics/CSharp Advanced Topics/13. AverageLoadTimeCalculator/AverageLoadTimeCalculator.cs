using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        // Fix the decimal separator to be dot
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        // This program reads the report from the file report.txt. If you want to test it, change the contents of the file.
        StreamReader reportReader = new StreamReader("../../report.txt");
        string report = reportReader.ReadToEnd();
        string[] reportItems = report.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, List<double>> reportTimes = new Dictionary<string, List<double>>();
        foreach (string item in reportItems)
        {
            string[] split = item.Split(' ');
            if (!reportTimes.ContainsKey(split[2]))
            {
                reportTimes[split[2]] = new List<double>() { double.Parse(split[3]) };
            }
            else
            {
                reportTimes[split[2]].Add(double.Parse(split[3]));
            }
        }

        foreach (var time in reportTimes)
        {
            Console.WriteLine("{0} -> {1}", time.Key, time.Value.Average());
        }
    }
}