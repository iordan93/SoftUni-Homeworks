using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter your numbers: ");
        string numbersAsString = Console.ReadLine();
        string[] numbersSplit = numbersAsString.Split(' ');
        double sum = 0;
        foreach (var number in numbersSplit)
        {
            sum += double.Parse(number);
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}
