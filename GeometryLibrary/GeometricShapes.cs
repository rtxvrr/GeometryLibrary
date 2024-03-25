using System;

namespace GeometryLibrary
{
    // Интерфейс для фигур
    public interface IShape
    {
        double CalculateArea();
    }

    // Базовый класс для фигур
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();
    }

    // Класс для круга
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом", nameof(radius));

            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    // Класс для треугольника
    public class Triangle : Shape
    {
        private readonly double[] _sides;

        public Triangle(double[] sides)
        {
            if (sides.Length != 3)
                throw new ArgumentException("Для треугольника требуется ровно 3 стороны", nameof(sides));

            _sides = sides;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (_sides[0] + _sides[1] + _sides[2]) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - _sides[0]) * (semiPerimeter - _sides[1]) * (semiPerimeter - _sides[2]));
            return area;
        }

        public bool IsRightAngleTriangle()
        {
            Array.Sort(_sides);
            return _sides[0] * _sides[0] + _sides[1] * _sides[1] == _sides[2] * _sides[2];
        }
    }

    // Класс для квадрата (Пример того, как можно легко добавить новые фигуры, используя интерфейс Shape)
    public class Square : Shape
    {
        private readonly double _side;

        public Square(double side)
        {
            if (side <= 0)
                throw new ArgumentException("Сторона квадрата должна быть положительным числом", nameof(side));

            _side = side;
        }

        public override double CalculateArea()
        {
            return _side * _side;
        }
    }
}
