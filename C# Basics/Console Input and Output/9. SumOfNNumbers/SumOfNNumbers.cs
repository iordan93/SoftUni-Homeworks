using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter the number n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        Console.WriteLine("Now enter {0} more number{1}:", n, n == 1 ? "" : "s");
        for (int i = 1; i <= n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}