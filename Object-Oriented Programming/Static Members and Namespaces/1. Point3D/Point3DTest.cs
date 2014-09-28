using System;

public class Point3DTest
{
    public static void Main()
    {
        Point3D point = new Point3D(5.3, 5, 5);
        Console.WriteLine(point);
        Console.WriteLine(Point3D.StartingPoint);
    }
}
