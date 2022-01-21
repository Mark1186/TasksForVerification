using System;
using Xunit;

namespace AreaFigures.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(3, 1)]
        [InlineData(13, 2)]
        [InlineData(28, 3)]
        [InlineData(50, 4)]
        [InlineData(79, 5)]
        [InlineData(79, -5)]
        [InlineData(50, -4)]
        public void CalculateArea_ShouldReturnCorrectResult(int expected, int radius)
        {
            //Arrange
            Circle circle = new Circle();
            circle.Radius = radius;

            //Act
            var actual = circle.CalculateArea();

            //Assert
            Assert.Equal(expected, Math.Round(actual));
        }
    }
}
