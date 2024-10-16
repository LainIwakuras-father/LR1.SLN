namespace MyfirstApp
{
         public class Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                 X = x;
                 Y = y;
            }
        }

        public class LineSegment
        {
            public Point Start { get; set; }
            public Point End { get; set; }
            public double Length { get; set; }
            public double Angle { get; set; }

            public LineSegment(Point start, Point end)
            {
                Start = start;
                End = end;
                Length = CalculateLength();
                Angle = CalculateAngle();
            }

            public double CalculateLength()
            {
                return Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
            }

            public double CalculateAngle()
            {
                if (End.X - Start.X == 0)
                    return Math.PI / 2;  // 90 degrees, vertical line
                return Math.Atan2(End.Y - Start.Y, End.X - Start.X);
            }

        }

        public class Polygon
        {
            private List<Point> points;

            public Polygon()
            {
                points = new List<Point>();
            }

            public void AddPoint(Point point)
            {
                points.Add(point);
            }

            public double CalculateTotalLength()
            {
                double totalLength = 0;
                for (int i = 0; i < points.Count - 1; i++)
                {
                    var segment = new LineSegment(points[i], points[i + 1]);
                    totalLength += segment.Length;
                }
                return totalLength;
            }

        }
    
}