using System;

class Polygon
{
    private Point[] points;

    public Polygon(Point[] points)
    {
        this.Points = points;
    }

    public Point[] Points
    {
        get
        {
            return this.points;
        }
        set
        {
            this.points = value;
        }
    }

    public double GetPerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < this.Points.Length - 1; i++)
        {
            perimeter += this.Points[i].DistanceTo(this.Points[i + 1]);
        }

        perimeter += this.Points[this.Points.Length - 1].DistanceTo(this.Points[0]);

        return perimeter;
    }

    public double GetArea()
    {
        double area = 0;
        for (int i = 0; i < this.Points.Length - 1; i++)
        {
            area += (this.Points[i].X * this.Points[i + 1].Y) - (this.Points[i].Y * this.Points[i + 1].X);
        }

        return Math.Abs(area / 2);
    }
}