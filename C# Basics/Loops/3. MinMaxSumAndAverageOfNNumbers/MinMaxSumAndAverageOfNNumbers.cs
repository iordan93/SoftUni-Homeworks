using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Now enter {0} more numbers:", n);
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;

        for (int i = 0; i < n; i++)
        {
            double current = double.Parse(Console.ReadLine());
            sum += current;
            if (current < min)
            {
                min = current;
            }

            if (current > max)
            {
                max = current;
            }
        }

        Console.WriteLine("min = {0}\r\nmax = {1}\r\nsum = {2}\r\navg = {3:F2}", min, max, sum, sum / n);
    }
}