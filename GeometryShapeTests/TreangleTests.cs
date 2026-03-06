using GeometryShape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapeTests
{
    public class TriangleTests
    {
        [Fact]
        public void Create_Triangle()
        {
            var tri = new Triangle(3, 3, 4); 

            Assert.Equal(3, tri.SideA); 
            Assert.Equal(3, tri.SideB);
            Assert.Equal(4, tri.SideC);
        }

        [Theory]
        [InlineData(0, 4, 5)]
        [InlineData(-1, 3, 4)]
        [InlineData(1, 1, 3)]
        public void Invalid_Input(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
        [Theory]
        [InlineData(3, 4, 5, 6)] 
        public void Area_Triangle(double a, double b, double c, double expected)
        {
            var tri = new Triangle(a, b, c);
            var actual = tri.Area();
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 4, 5)]
        public void Perimeter_Triangle(double sideA, double sideB, double sideC)
        {
            var expectedPerimeter = sideA + sideB + sideC;
            var tri = new Triangle(sideA, sideB, sideC);

            var actualPerimeter = tri.Perimeter();
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        [Theory]
        [InlineData(0, 4, 5)]
        public void ToString_Triangle(double a, double b, double c)
        {

            var tri = new Triangle(a, b, c);
            var area = 6; 
            var perimeter = a + b + c;
            var expectedString = $"Треугольник: {a} x {b} x {c}, с площадью: {area}, и периметром: {perimeter}";
            var actualString = tri.ToString();

            Assert.Equal(expectedString, actualString);
        }

        [Fact]
        public void ToString_Triangle_ContainsCorrectFormat()
        {
            var tri = new Triangle(3, 3, 4);

            var result = tri.ToString();

            Assert.Contains("Треугольник:", result);
            Assert.Contains("x", result);
            Assert.Contains(", с площадью:", result);
            Assert.Contains(", и периметром:", result);
        }
    }
}