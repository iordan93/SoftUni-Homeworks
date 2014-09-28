using System;

public class Point3D
{
    private static readonly Point3D startingPoint = new Point3D();

    public Point3D()
        : this(0, 0, 0)
    {
    }

    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public double X { get; private set; }

    public double Y { get; private set; }

    public double Z { get; private set; }

    public static Point3D StartingPoint
    {
        get
        {
            return Point3D.startingPoint;
        }
    }

    public override string ToString()
    {
        return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
    }
}