using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

public static class Storage
{
    private const string BasePath = "../../";
    private const string DefaultExtension = "txt";

    public static void WritePath(string pathId, Path3D path)
    {
        var oldCulture = Thread.CurrentThread.CurrentCulture;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        StreamWriter writer = new StreamWriter(BasePath + pathId + "." + DefaultExtension);
        using (writer)
        {
            foreach (var point in path)
            {
                writer.WriteLine(point);
            }
        }

        Thread.CurrentThread.CurrentCulture = oldCulture;
    }

    public static Path3D GetPath(string pathId)
    {
        string filePath = BasePath + pathId + "." + DefaultExtension;
        if (File.Exists(filePath))
        {
            StreamReader reader = new StreamReader(filePath);
            Path3D path = new Path3D();            
            using (reader)
            {
                string[] pointsAsStrings = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var pointAsString in pointsAsStrings)
                {
                    double[] coordinates = pointAsString
                        .Substring(1, pointAsString.Length - 2).Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(p => double.Parse(p, CultureInfo.InvariantCulture))
                        .ToArray();
                    path.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                }
            }

            return path;
        }
        else
        {
            throw new InvalidOperationException("There is no path with ID " + pathId + ".");
        }
    }
}
