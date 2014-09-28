using System;
public class PathsTest
{
    public static void Main()
    {
        var path = new Path3D(new Point3D[] 
        {
            new Point3D(4.5, 2, -5.4455),
            new Point3D(0, 0, 5),
            new Point3D(-5, -4.256, 86.4252),
            new Point3D(542, 5678.545, 47)
        });

        foreach (var point in path)
        {
            Console.WriteLine(point);
        }

        Console.WriteLine();
        Console.WriteLine("Storing and saving paths:");
        Storage.WritePath("myPath", path);
        var pathFromFile = Storage.GetPath("myPath");
        foreach (var point in path)
        {
            Console.WriteLine(point);
        }
    }
}
