using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int currentNumber = 1;
        int row = 0;
        int column = 0;
        int maxRow = n - 1;
        int maxColumn = n - 1;
        
        do
        {
            //Move right
            for (int i = column; i <= maxColumn; i++)
            {
                matrix[row, i] = currentNumber;
                currentNumber++;
            }
            row++;
            //Move down
            for (int i = row; i <= maxRow; i++)
            {
                matrix[i, maxColumn] = currentNumber;
                currentNumber++;
            }
            maxColumn--;
            //Move left
            for (int i = maxColumn; i >= column; i--)
            {
                matrix[maxRow, i] = currentNumber;
                currentNumber++;
            }
            maxRow--;
            //Move up
            for (int i = maxRow; i >= row; i--)
            {
                matrix[i, column] = currentNumber;
                currentNumber++;
            }
            column++;
        }
        while (currentNumber <= n * n);

        //Print results
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                Console.Write("{0, 4}", matrix[rows, columns]);
            }

            Console.WriteLine();
        }
    }
}