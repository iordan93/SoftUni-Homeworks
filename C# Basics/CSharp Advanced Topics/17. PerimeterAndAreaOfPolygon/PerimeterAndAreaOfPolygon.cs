using System;
using System.Collections.Generic;

class PerimeterAndAreaOfPolygon
{
    static void Main()
    {
        Console.Write("Enter the number of points of the polygon: ");
        int pointsCount = int.Parse(Console.ReadLine());
        Point[] points = new Point[pointsCount];
        for (int i = 0; i < pointsCount; i++)
        {
            points[i] = Point.Parse(Console.ReadLine());
        }

        Polygon polygon = new Polygon(points);
        Console.WriteLine("Perimeter: {0:F2}", polygon.GetPerimeter());
        Console.WriteLine("Area: {0:F2}", polygon.GetArea());
    }
}