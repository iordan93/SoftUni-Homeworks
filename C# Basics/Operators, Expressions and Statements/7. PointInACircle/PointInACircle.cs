using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter the point's x coordinate: ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter the point's y coordinate: ");
        double pointY = double.Parse(Console.ReadLine());
        if (Math.Pow(pointX, 2) + Math.Pow(pointY, 2) <= 4)
        {
            Console.WriteLine("The point is in the circle ((0, 0), 2)");
        }
        else
        {
            Console.WriteLine("The point is outside the circle ((0, 0), 2)");
        }
    }
}