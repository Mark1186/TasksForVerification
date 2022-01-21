using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AreaFigures.Tests
{
    public class RectangleTests
    {
        [Theory]
        [InlineData(5, 1, 5)]
        [InlineData(10, 2, 5)]
        [InlineData(25, 5, 5)]
        [InlineData(21, 3, 7)]
        [InlineData(48, 6, 8)]
        public void CalculateArea_ShouldReturnCorrectResult(int expected, double a, double b)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SideA = a;
            rectangle.SideB = b;

            var actual = rectangle.CalculateArea();

            Assert.Equal(expected, actual);
        }
    }
}
