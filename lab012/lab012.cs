using System;

namespace lab012 {
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        private double CalculateArea()
        {
            return side1 * side2;
        }

        private double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }

    class lab012
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Side1:");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Side2:");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(sideA, sideB);

            Console.WriteLine($"Rectangle perimeter: {rectangle.Perimeter}");
            Console.WriteLine($"Rectangle area: {rectangle.Area}");
        }
    }
}