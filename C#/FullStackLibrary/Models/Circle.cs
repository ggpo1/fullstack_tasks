using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackLibrary.Models
{
    // Модель круга
    public class Circle
    {
        public Circle(double radius)
        {
            this.Radius = radius;
            this.Diameter = radius * 2;
        }

        public double Radius { get; set; }
        public double Diameter { get; }
    }
}
