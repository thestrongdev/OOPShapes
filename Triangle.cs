using System;
using System.Collections.Generic;
using System.Text;

namespace OOPShapes
{
    class Triangle : ShapeBase
    {
        public double side1Length { get; set; }
        public double side2Length { get; set; }
        public double side3length { get; set; }

        public override double CalculateArea()
        {
            double halfPerimeter = this.CalculatePerimeter() / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - side1Length) * (halfPerimeter - side2Length) * (halfPerimeter * side3length));

            return Math.Round(area, 2);
        }
        
        public override double CalculatePerimeter()
        {
            double perimeter = (this.side1Length + this.side2Length + this.side3length);
            return Math.Round(perimeter, 2);
        }


    }
}
