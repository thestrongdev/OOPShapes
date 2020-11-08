using System;
using System.Collections.Generic;
using System.Text;

namespace OOPShapes
{
    class Square : ShapeBase
    {
        public double SideLength { get; set; }

        public override double CalculatePerimeter()
        {
            return 4 * SideLength;
        }

        public override double CalculateArea()
        {
            return 2 * SideLength;
        }
    }
}
