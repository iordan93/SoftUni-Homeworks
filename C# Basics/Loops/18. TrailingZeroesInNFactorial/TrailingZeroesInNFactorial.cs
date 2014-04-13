using System;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            double sum = 0;
            int add = 0;
            do
            {
                add = n / 5;
                n = add;
                sum += add;
            } while (add > 0);

            Console.WriteLine(sum);
        }
    }
}