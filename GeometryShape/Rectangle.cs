using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            if(width <= 0 || height <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными");
            }
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return (Width + Height) * 2;
        }
        public override string ToString()
        {
            return $"Прямоугольник: {Width} x {Height}, с площадью: {Area()}, и периметром: {Perimeter()}";
        }
    }
}
