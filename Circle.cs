using System;
using System.Collections.Generic;
using System.Text;

namespace OOPShapes
{
    class Circle : ShapeBase
    {
        private double _radius; //diameter is 2 * radius

        public double Radius { get => _radius; set => _radius = value; }

        public const double PI = Math.PI;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculatePerimeter() //actually circumference but must inherit from BASE class; 2 * pi * radius
        {
            double circumference = 2 * PI * Radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
            return $"Circumference: {FormatNumber(this.CalculatePerimeter())}";
        }

        public override double CalculateArea() // pi * radius^2
        {
            double area = PI * Radius * Radius;
            return area;
        }

        public string CalculateFormattedArea()
        {
            return $"Area: {FormatNumber(this.CalculateArea())}";
        }

        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}
