using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
using System;

namespace GeometryLibraryTests
{
    [TestClass]
    public class GeometryCalculatorTests
    {
        [TestMethod]
        public void CircleArea_CorrectRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            Circle circle = new Circle(radius);

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TriangleArea_CorrectSides_ReturnsCorrectArea()
        {
            // Arrange
            double[] sides = new double[] { 3, 4, 5 };
            double expectedArea = 6;
            Triangle triangle = new Triangle(sides);

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void IsRightAngleTriangle_RightTriangle_ReturnsTrue()
        {
            // Arrange
            double[] sides = new double[] { 3, 4, 5 };
            Triangle triangle = new Triangle(sides);

            // Act
            bool isRightAngle = triangle.IsRightAngleTriangle();

            // Assert
            Assert.IsTrue(isRightAngle);
        }

        [TestMethod]
        public void SquareArea_CorrectSide_ReturnsCorrectArea()
        {
            // Arrange
            double side = 4;
            double expectedArea = 16;
            Square square = new Square(side);

            // Act
            double actualArea = square.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
