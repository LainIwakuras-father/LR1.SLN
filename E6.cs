namespace MyfirstApp
{
    internal class Rectangle1
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public Rectangle1(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        public double GetPerimeter()
        {
            double length = Math.Abs(X2 - X1);
            double width = Math.Abs(Y2 - Y1);
            return 2 * (length + width);
        }
        public double GetArea()
        {
            double length = Math.Abs(X2 - X1);
            double width = Math.Abs(Y2 - Y1);
            return length * width;
        }
        public string Info
        {
            get
            {
                return $"Координаты: Левый верхний ({X1}, {Y1}), Правый нижний ({X2}, {Y2}), " +
                       $"Площадь: {GetArea()}, Периметр: {GetPerimeter()}";
            }
        }
    }
}