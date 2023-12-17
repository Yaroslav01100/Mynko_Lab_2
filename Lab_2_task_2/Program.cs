using System;

namespace Lab_2_task_2
{
    public class Point
    {
        private double x;
        private double y;
        private string name;

        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }
    }

    public class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += GetSideLength(points[i], points[i + 1]);
            }
            perimeter += GetSideLength(points[points.Length - 1], points[0]);

            Console.WriteLine("Минко Ярослав");

            Console.WriteLine($"Периметр багатокутника: {perimeter}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 2, "A");
            Point B = new Point(5, 6, "B");
            Point C = new Point(2, 0, "C");
            Point D = new Point(3, 1, "D");

            Figure rectangle = new Figure(A, B, C, D);

            rectangle.CalculatePerimeter();
        }
    }

}