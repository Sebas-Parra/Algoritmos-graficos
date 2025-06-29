using System;
using System.Collections.Generic;
using System.Drawing;

namespace DrawLies2
{
    public static class SutherlandHodgman
    {
        public static List<Point> ClipPolygon(List<Point> polygon, Rectangle clipRect)
        {
            List<Point> outputList = polygon;

            // Usamos Tuple en lugar de tuplas con nombres y sin "new()"
            List<Tuple<Func<Point, bool>, Func<Point, Point, Point>>> edges = new List<Tuple<Func<Point, bool>, Func<Point, Point, Point>>>()
            {
                // LEFT
                Tuple.Create<Func<Point, bool>, Func<Point, Point, Point>>(
                    p => p.X >= clipRect.Left,
                    (p1, p2) => new Point(clipRect.Left,
                        p1.Y + (p2.Y - p1.Y) * (clipRect.Left - p1.X) / (p2.X - p1.X))
                ),
                // RIGHT
                Tuple.Create<Func<Point, bool>, Func<Point, Point, Point>>(
                    p => p.X <= clipRect.Right,
                    (p1, p2) => new Point(clipRect.Right,
                        p1.Y + (p2.Y - p1.Y) * (clipRect.Right - p1.X) / (p2.X - p1.X))
                ),
                // TOP
                Tuple.Create<Func<Point, bool>, Func<Point, Point, Point>>(
                    p => p.Y >= clipRect.Top,
                    (p1, p2) => new Point(
                        p1.X + (p2.X - p1.X) * (clipRect.Top - p1.Y) / (p2.Y - p1.Y),
                        clipRect.Top)
                ),
                // BOTTOM
                Tuple.Create<Func<Point, bool>, Func<Point, Point, Point>>(
                    p => p.Y <= clipRect.Bottom,
                    (p1, p2) => new Point(
                        p1.X + (p2.X - p1.X) * (clipRect.Bottom - p1.Y) / (p2.Y - p1.Y),
                        clipRect.Bottom)
                )
            };

            foreach (var edge in edges)
            {
                Func<Point, bool> Inside = edge.Item1;
                Func<Point, Point, Point> Intersect = edge.Item2;

                List<Point> inputList = outputList;
                outputList = new List<Point>();

                if (inputList.Count == 0) break;

                Point s = inputList[inputList.Count - 1];

                foreach (Point e in inputList)
                {
                    if (Inside(e))
                    {
                        if (!Inside(s))
                            outputList.Add(Intersect(s, e));
                        outputList.Add(e);
                    }
                    else if (Inside(s))
                    {
                        outputList.Add(Intersect(s, e));
                    }
                    s = e;
                }
            }

            return outputList;
        }
    }
}
