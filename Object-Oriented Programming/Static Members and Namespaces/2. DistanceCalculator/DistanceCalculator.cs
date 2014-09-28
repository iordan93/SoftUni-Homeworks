using System;
public static class DistanceCalculator
{
    public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
    {
        return Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2) + Math.Pow(secondPoint.Z - firstPoint.Z, 2));
    }
}
