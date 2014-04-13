using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double third = double.Parse(Console.ReadLine());
        double biggestNumber = double.MinValue;

        if (first > second)
        {
            if (third > first)
            {
                biggestNumber = third;
            }
            else
            {
                biggestNumber = first;
            }
        }
        else
        {
            if (third > second)
            {
                biggestNumber = third;
            }
            else
            {
                biggestNumber = second;
            }
        }

        // Alternative solution:
        // biggestNumber = Math.Max(Math.Max(first, second), third);

        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}