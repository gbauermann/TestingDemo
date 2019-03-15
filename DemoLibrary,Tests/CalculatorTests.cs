using System;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_Test()
        {
            var expected = 29;

            var actual = Calculator.Add(14, 15);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.23, 26.23)]
        public void Add_TestV2(double x, double y, double expected)
        {
           
            var actual = Calculator.Add(x, y);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void DivideTest(double x, double y, double expected)
        {
            var actual = Calculator.Divide(x, y);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideByZeroTest()
        {           
            Assert.Throws< DivideByZeroException>(()=> Calculator.Divide(15, 0));
        }
    }
}
