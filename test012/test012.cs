using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab012;

namespace test012 {

    [TestClass]
    public class RectangleTests {
        [TestMethod]
        public void CalculateArea_ValidInput_ReturnsCorrectArea() {
            double sideA = 5.0;
            double sideB = 4.0;

            lab012.Rectangle rectangle = new lab012.Rectangle(sideA, sideB);

            double area = rectangle.Area; 

            Assert.AreEqual(20.0, area, 0.001);
        }

        [TestMethod]
        public void CalculatePerimeter_ValidInput_ReturnsCorrectPerimeter() {
            double sideA = 5.0;
            double sideB = 4.0;
            lab012.Rectangle rectangle = new lab012.Rectangle(sideA, sideB);

            double perimeter = rectangle.Perimeter;

            Assert.AreEqual(18.0, perimeter, 0.001);
        }
    }

}

