using System;
using System.Collections.Generic;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers, separated by spaces: ");
        string[] numbersSplit = Console.ReadLine().Split(' ');
        double[] numbers = new double[numbersSplit.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(numbersSplit[i]);
        }

        int answer = 0;
        
        // The loop goes from 1 to all possible subsets, excluding the initial set (that is why there is -1 in the loop)
        for (int i = 1; i <= Math.Pow(2, numbers.Length) - 1; i++)
        {
            double currentSum = 0;
            for (int j = 1; j <= numbers.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += numbers[j - 1];
                }
            }

            if (currentSum == 0)
            {
                answer++;
            }
        }

        if (answer == 1)
        {
            Console.WriteLine("There is 1 subset whose sum is 0");
        }
        else
        {
            Console.WriteLine("There are {0} subsets whose sum is 0", answer);
        }
    }
}