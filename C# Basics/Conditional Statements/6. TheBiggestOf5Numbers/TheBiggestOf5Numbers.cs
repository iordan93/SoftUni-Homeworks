using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double third = double.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        double fourth = double.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        double fifth = double.Parse(Console.ReadLine());

        double max12 = Math.Max(first, second);
        double max34 = Math.Max(third, fourth);
        double biggestNumber = double.MinValue;
        if (max12 < max34)
        {
            if (max34 < fifth)
            {
                biggestNumber = fifth;
            }
            else
            {
                biggestNumber = max34;
            }
        }
        else
        {
            if (max12 < fifth)
            {
                biggestNumber = fifth;
            }
            else
            {
                biggestNumber = max12;
            }
        }

        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}
