using System;

public class DistanceCalculatorTest
{
    public static void Main()
    {
        Point3D point = new Point3D(5, 5, 5);
        Console.WriteLine(DistanceCalculator.CalculateDistance(point, Point3D.StartingPoint));
    }
}
