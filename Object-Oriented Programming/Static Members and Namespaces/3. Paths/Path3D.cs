using System;
using System.Collections;
using System.Collections.Generic;
public class Path3D : IEnumerable<Point3D>
{
    public Path3D()
        : this(new List<Point3D>())
    {
    }

    public Path3D(IList<Point3D> points)
    {
        this.Points = points;
    }

    public IList<Point3D> Points { get; set; }

    public void AddPoint(Point3D point)
    {
        this.Points.Add(point);
    }

    public void RemovePoint(Point3D point)
    {
        this.Points.Remove(point);
    }

    public void RemovePointAt(int index)
    {
        this.Points.RemoveAt(index);
    }

    public Point3D GetPointAt(int index)
    {
        return this.Points[index];
    }

    public IEnumerator<Point3D> GetEnumerator()
    {
        return this.Points.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.Points.GetEnumerator();
    }
}
