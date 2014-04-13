using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value v (0 or 1): ");
        int v = int.Parse(Console.ReadLine());
        
        if (v == 0)
        {
            n = n & (~(1 << p));
            Console.WriteLine(n);
        }
        else if (v == 1)
        {
            n = n | (1 << p);
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("Enter a proper value for v.");
        }
    }
}