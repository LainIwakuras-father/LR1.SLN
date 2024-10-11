namespace MyfirstApp
{
    internal class Triangle
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
        }
        private double GetSideLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public double GetPerimeter()
        {
            double sideA = GetSideLength(X1, Y1, X2, Y2);
            double sideB = GetSideLength(X2, Y2, X3, Y3);
            double sideC = GetSideLength(X3, Y3, X1, Y1);
            return sideA + sideB + sideC;
        }
        public double GetArea()
        {
            double sideA = GetSideLength(X1, Y1, X2, Y2);
            double sideB = GetSideLength(X2, Y2, X3, Y3);
            double sideC = GetSideLength(X3, Y3, X1, Y1);
            double semiPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }
        public string Info
        {
            get
            {
                return $"Координаты вершин: A({X1}, {Y1}), B({X2}, {Y2}), C({X3}, {Y3}), " +
                       $"Площадь: {GetArea()}, Периметр: {GetPerimeter()}";
            }
        }
    }
}