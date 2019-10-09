using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackLibrary.Models
{
    public class Triangle
    {
        // Модель треугольника
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
            this.Perimeter = firstSide + secondSide + thirdSide;
            this.IsRectangular = (thirdSide * thirdSide) == (firstSide * firstSide + secondSide * secondSide);
        }

        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        public double Perimeter { get; }
        public bool IsRectangular { get; }
    }
}
