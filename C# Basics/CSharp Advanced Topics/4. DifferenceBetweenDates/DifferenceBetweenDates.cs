using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Enter the first date (example format: 20.09.2002): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter the second date (example format: 20.09.2002): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("The difference between the two dates is: {0} days.", (secondDate - firstDate).Days);
    }
}