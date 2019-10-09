using FullStackLibrary.Interfaces;
using FullStackLibrary.Models;
using System;


namespace FullStackLibrary
{
    public class FullStackLibrary : IFullStackLibrary
    {
        // Метод для вычисления площади круга
        public double GetCircleSquare(Circle circle)
        {
            return Math.PI * (circle.Radius * circle.Radius);
        }
        // Метод для вычисления площади треугольника
        public double GetTriangleSquare(Triangle triangle)
        {
            return Math.Sqrt(
                triangle.Perimeter * (triangle.Perimeter - triangle.FirstSide) * (triangle.Perimeter - triangle.SecondSide) * (triangle.Perimeter - triangle.ThirdSide)
            );
        }
    }
}
