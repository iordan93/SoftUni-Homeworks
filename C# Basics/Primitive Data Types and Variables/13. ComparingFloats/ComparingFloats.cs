using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001; // Alternative format: 1e-6
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        bool equal = false;

        // If the numbers have different signs, they cannot be equal
        if ((a > 0 && b > 0) || (a < 0 && b < 0))
        {
            equal = Math.Abs(a - b) < eps;
        }

        Console.WriteLine("Are the numbers equal? {0}", equal);
    }
}