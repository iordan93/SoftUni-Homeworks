using System;

class Point
{
    private double x;
    private double y;
    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public double X
    {
        get
        {
            return this.x;
        }
        set
        {
            this.x = value;
        }
    }
    public double Y
    {
        get
        {
            return this.y;
        }
        set
        {
            this.y = value;
        }
    }

    public static Point Parse(string pointAsString)
    {
        string[] split = pointAsString.Split(' ');
        return new Point(double.Parse(split[0]), double.Parse(split[1]));
    }

    public double DistanceTo(Point other)
    {
        return Math.Sqrt(Math.Pow(other.X - this.X, 2) + Math.Pow(other.Y - this.Y, 2));
    }
}