using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Point3D
{
    class Path
    {
        private List<Point3D> points = new List<Point3D>();
        private static readonly string separator = Environment.NewLine;

        public Path Add(params Point3D[] points)
        {
            foreach (Point3D point in points)
                this.points.Add(point);
            return this;
        }

        public Path Remove(Point3D point)
        {
            this.points.Remove(point);
            return this;
        }

        public static Path Parse(string path)
        {
            Point3D[] points = Regex.Split(path, separator).Select(Point3D.Parse).ToArray();
            return new Path().Add(points);
        }

        public override string ToString()
        {
            return String.Join(separator, points);
        }
    }
}
