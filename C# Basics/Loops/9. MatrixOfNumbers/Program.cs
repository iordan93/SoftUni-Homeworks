using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 20)
        {
            Console.WriteLine("The number n should be between 1 and 20.");
            return;
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = row + 1; col <= n + row; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }
    }
}