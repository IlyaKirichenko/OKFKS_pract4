namespace GeometryShapeTests
{
    using GeometryShape;
    using System.Reflection.Metadata;

    public class RectangleTests
    {
        [Fact]
        public void Create_Rectangles()
        {
            var rec = new Rectangle(5, 3);

            Assert.Equal(5, rec.Width);
            Assert.Equal(3, rec.Height);
        }
        [Theory]
        [InlineData(0, 5)]
        [InlineData(-1, 3)]
        public void Invalid_Input(double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
        }

        [Theory]
        [InlineData(4, 5)]
        public void Area_Rectangle(double width, double height)
        {
            var expectedArea = width * height;
            var rect = new Rectangle(width, height);

            var actualArea = rect.Area();

            Assert.Equal(expectedArea, actualArea);
        }
        [Theory]
        [InlineData(4, 5)]
        public void Perimetr_Rectangle(double width, double height)
        {
            var expectedPerimetr = (width + height) * 2;
            var rect = new Rectangle(width, height);

            var actualPerimetr = rect.Perimeter();

            Assert.Equal(expectedPerimetr, actualPerimetr);
        }
        [Theory]
        [InlineData(6, 8)]
        public void ToString_Rectangle(double width, double height)
        {
            var rect = new Rectangle(width, height);
            var area = width * height;
            var perimeter = (width + height) * 2;

            var expectedString = $"Прямоугольник: {width} x {height}, с площадью: {area}, и периметром: {perimeter}";

            var actualString = rect.ToString();

            Assert.Equal(expectedString, actualString);
        }
        [Fact]
        public void ToString_ContainsCorrectFormat()
        {
            var rect = new Rectangle(4, 5);

            var result = rect.ToString();

            Assert.Contains("Прямоугольник:", result);
            Assert.Contains("x", result);
            Assert.Contains(", с площадью:", result);
            Assert.Contains(", и периметром:", result);
        }
    }
}