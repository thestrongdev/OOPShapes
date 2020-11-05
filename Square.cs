using System;
using System.Collections.Generic;
using System.Text;

namespace OOPShapes
{
    class Square
    {
        public int SideLength { get; set; }

        public int CalculatePerimeter()
        {
            return 4 * SideLength;
        }

        public int CalculateArea()
        {
            return 2 * SideLength;
        }
    }
}
