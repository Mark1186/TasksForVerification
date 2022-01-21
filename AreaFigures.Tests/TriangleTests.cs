using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AreaFigures.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 2, 3, 4)]
        [InlineData(6, 3, 4, 5)]
        [InlineData(10, 4, 5, 6)]
        [InlineData(3, -2, -3, -4)]
        public void CalculateArea_ShouldReturnCorrectResult(int expected, double a, double b, double c)
        {
            Triangle triangle = new Triangle();
            triangle.SideA = a;
            triangle.SideB = b;
            triangle.SideC = c;

            var actual = triangle.CalculateArea();

            Assert.Equal(expected, Math.Round(actual));
        }
    }
}
