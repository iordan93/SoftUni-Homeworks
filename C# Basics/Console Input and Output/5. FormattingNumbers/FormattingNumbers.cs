using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Please enter an integer between 0 and 500: ");
        // I am not going to check the input for the time being
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter a floating-point number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter another floating-point number: ");
        double c = double.Parse(Console.ReadLine());

        string lastColumn = string.Empty;

        // A simple check to see if c is actually an integer number
        // (and avoid being printed with zeroes)
        if ((int)c == c)
        {
            lastColumn = string.Format("{0,-10}", c);
        }
        else
        {
            lastColumn = string.Format("{0,-10:F3}", c);
        }

        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, lastColumn);
    }
}