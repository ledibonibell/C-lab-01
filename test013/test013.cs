using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab013;

namespace test013 {

    [TestClass]
    public class PointTests {
        [TestMethod]
        public void Point_Constructor_SetsXAndY() {
            int x = 3;
            int y = 4;

            Point point = new Point(x, y);

            Assert.AreEqual(x, point.X);
            Assert.AreEqual(y, point.Y);
        }
    }

    [TestClass]
    public class FigureTests {
        [TestMethod]
        public void Figure_LengthSide_CalculatesCorrectLength() {
            Point A = new Point(0, 0);
            Point B = new Point(0, 3);
            Figure figure = new Figure(A, B);

            double length = figure.LengthSide(A, B);

            Assert.AreEqual(3.0, length, 0.001);
        }

        [TestMethod]
        public void Figure_PerimeterCalculator_CalculatesCorrectPerimeter() {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(1, 1);
            Point p4 = new Point(1, 0);

            Figure square = new Figure(p1, p2, p3, p4) {
                Name = "square",
            };
            //square.PerimeterCalculator();

            Assert.AreEqual(4.0, square.PerimeterCalculator(), 0.001);
        }

        [TestMethod]
        public void Figure_PerimeterCalculator_WithNullPoints() {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(1, 1);
            Point p4 = new Point(1, 0);

            Figure triangle = new Figure(p1, p2, p3) {
                Name = "triangle",
            };
            //triangle.PerimeterCalculator();

            Assert.AreEqual(3.414, triangle.PerimeterCalculator(), 0.001);
        }
    }
}
