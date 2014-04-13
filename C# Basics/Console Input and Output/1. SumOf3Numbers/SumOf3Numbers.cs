using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        float first = float.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        float second = float.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        float third = float.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the three numbers is: {0}", first + second + third);
    }
}