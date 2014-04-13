using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter a four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        int a = (number / 1000) % 10;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;

        Console.WriteLine("Sum of digits: {0}\r\nReversed: {1}\r\nLast digit in front: {2}\r\nSecond and third digits exchanged: {3}",
            (a + b + c + d),
            "" + d + c + b + a,
            "" + d + a + b + c,
            "" + a + c + b + d);
    }
}
