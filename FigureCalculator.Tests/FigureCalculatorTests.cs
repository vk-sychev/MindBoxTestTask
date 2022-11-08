using Xunit;

namespace FigureCalculator.Tests
{
    public class FigureCalculatorTests
    {
        [Fact]
        public void TestTriangleNegativeOrZeroSide()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-10, 0, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(0, -10, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, -10));
            Assert.Throws<ArgumentException>(() => new Triangle(-10, -10, -10));
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
        }

        [Fact]
        public void TestCircleNegativeOrZeroRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void TestCircleCalculation()
        {
            var circle = new Circle(5);

            var square = circle.Square;

            Assert.Equal(78.5, square);
        }

        [Fact]
        public void TestTriangleCalculation()
        {
            var triangle = new Triangle(3, 4, 5);

            var triangleSquare = triangle.Square;

            Assert.Equal(6, triangleSquare);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(2, 2, 3, false)]
        public void TestIsRightTriangle(int a, int b, int c, bool isRight)
        {
            var triangle = new Triangle(a, b, c);
            var isRightTriangle = triangle.IsRightTriangle;

            if (isRight)
            {
                Assert.True(isRightTriangle);
            }
            else
            {
                Assert.False(isRightTriangle);
            }          
        }
    }
}