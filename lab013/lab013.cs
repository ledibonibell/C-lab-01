using System;

namespace lab013 {
    public class Point {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            private set { x = value; }
        }

        public int Y
        {
            get { return y; }
            private set { y = value; }
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Figure {
        private Point[] points;

        private System.Drawing.Point p1;
        private System.Drawing.Point p2;
        private System.Drawing.Point p3;
        private System.Drawing.Point p4;

        private Point a;
        private Point b;

        public string Name
        {
            get;
            set;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3, p4, null)
        {

        }

        public Figure(Point p1, Point p2, Point p3) : this(p1, p2, p3, null, null)
        {

        }

        public Figure(System.Drawing.Point p11, System.Drawing.Point p21, Point p1, Point p2) : this(p1, p2, null, null, null)
        {

        }

        public Figure(System.Drawing.Point p1, System.Drawing.Point p2, System.Drawing.Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Figure(System.Drawing.Point p1, System.Drawing.Point p2, System.Drawing.Point p3, System.Drawing.Point p4) : this(p1, p2, p3)
        {
            this.p4 = p4;
        }

        public Figure(Point a, Point b)
        {
            this.a = a;
            this.b = b;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public double PerimeterCalculator() {
            double perimeter = 0;

            for (int i = 0; i < points.Length - 1; i++) {

                if (points[i] != null && points[i + 1] != null) {
                    perimeter += LengthSide(points[i], points[i + 1]);
                }
            }

            for (int i = 0; i < points.Length - 1; i++) {

                if (points[i] != null && points[i + 1] == null) {
                    perimeter += LengthSide(points[0], points[i]);
                }

            }
            Console.WriteLine($"The figure {Name} - perimeter: {perimeter}");
            return perimeter;
        }
    }

    class lab013 {
        static void Main() {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(1, 1);
            Point p4 = new Point(1, 0);

            Figure triangle = new Figure(p1, p2, p3) {
                Name = "triangle",
            };
            Figure square = new Figure(p1, p2, p3, p4) {
                Name = "squar",
            };

            triangle.PerimeterCalculator();
            square.PerimeterCalculator();
        }
    }
}