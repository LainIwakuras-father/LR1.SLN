namespace MyfirstApp
{
    internal class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public string Info
        {
            get
            {
                return $"Центр окружности: ({X}, {Y}), Радиус: {Radius}, " +
                       $"Длина окружности: {GetCircumference():F2}, Площадь: {GetArea():F2}";
            }
        }
    }
}