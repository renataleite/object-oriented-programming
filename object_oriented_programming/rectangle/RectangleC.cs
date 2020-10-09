using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class RectangleC
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return (Width * 2) + (Height * 2);
        }

        public double Diagonal()
        {
            double sum = Math.Pow(Width, 2) + Math.Pow(Height, 2);
            return Math.Sqrt(sum);
        }
    }
}
