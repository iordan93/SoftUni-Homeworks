using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstDotsLength = (n - 1) / 2;
        Console.WriteLine("{0}*{0}", new string('.', firstDotsLength));
        for (int row = 0; row < (n - 3) / 2; row++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', --firstDotsLength), new string('.', 2 * row + 1));
        }

        Console.WriteLine(new string('*', n));

        int outerDotsLength = n / 4;
        for (int row = 0; row < (n + 1) / 2 - 2; row++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDotsLength), new string('.', n - 2 * outerDotsLength - 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', outerDotsLength), new string('*', n - 2 * outerDotsLength));
    }
}