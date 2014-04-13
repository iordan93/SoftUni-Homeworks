using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers separated by spaces:");
        string[] inputSplit = Console.ReadLine().Split(' ');
        int[] numbers = new int[inputSplit.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(inputSplit[i]);
        }

        long oddProduct = 1;
        long evenProduct = 1;
        for (int i = 1; i <= numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= numbers[i - 1];
            }
            else
            {
                oddProduct *= numbers[i - 1];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}