using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными");
            }
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Такой треугольник не может существовать");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s-SideA)*(s-SideB)*(s-SideC));
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }
        public override string ToString()
        {
            return $"Треугольник: {SideA} x {SideB} x {SideC}, с площадью: {Area()}, и периметром: {Perimeter()}";
        }
    }
}
