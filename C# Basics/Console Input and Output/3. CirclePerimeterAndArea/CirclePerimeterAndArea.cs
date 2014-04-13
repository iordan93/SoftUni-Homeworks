using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the circle's radius: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("The perimeter of a circle with radius {0} is {1:F2} and the area is {2:F2}.", radius, perimeter, area);
    }
}
