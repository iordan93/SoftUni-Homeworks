using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter the rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter the rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter: {0}, area: {1}", 2 * (width + height), width * height);
    }
}