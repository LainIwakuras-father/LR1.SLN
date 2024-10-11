using System;
using System.Drawing;
namespace MyfirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point1 point = new Point1(1, 1, 1);
            point.MoveBy(5, 4, 3);
            Console.WriteLine($"X:{point.X},Y:{point.Y},Z:{point.Z}");

            User user = new User("Ложкин", "Александр", "Андреевич");
            Console.WriteLine(user.FullName);

            Computer computer = new("Lenovo",4.2,4,512);
            Console.WriteLine(computer.info);

            Laptop laptop = new("Android", 3,8 ,128, 20 );
            Console.WriteLine(laptop.info);

            Smartphone smartphone = new("TECNO", 4.2,4,4, "Android",5);
            Console.WriteLine(smartphone.info);
            Rectangle1 rectangle1 = new(10,10,1,1);
            Console.WriteLine(rectangle1.Info);

            Triangle triangle1 = new(1, 1, 5, 5, 1, 10);
            Console.WriteLine(triangle1.Info);

            Post post = new("18650", "Saint-Peterburg", "Дальневосточный проспект", "71", "1", "923", "Привет!Как дела?");
            Console.WriteLine(post.Address);
            

            Circle circle = new(0, 0, 5);
            Console.WriteLine(circle.Info);

            Polygon polygon = new();
            Console.WriteLine(polygon.CalculateTotalLength());
            Console.ReadKey();

        }
    }
    class Point1
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point1(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public void MoveBy(double dx, double dy, double dz)
        {
            X += dx;
            Y += dy;
            Z += dz;

        }
    }





}


