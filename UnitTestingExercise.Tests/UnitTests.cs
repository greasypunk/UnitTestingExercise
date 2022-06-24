using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-8, 3, 5, 0)] 
        [InlineData(2, 3, 95, 100)] 
        [InlineData(2, 300, -500, -198)] 
        [InlineData(1, -1, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            var calculatorTester = new Calculator();
            var actual = calculatorTester.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(2, 3, -1)]
        [InlineData(-8, 3, -11)]
        [InlineData(2, 300, -298)]
        [InlineData(1, -1, 2)]
        [InlineData(-5, 1, -6)]
        [InlineData(0, -1, 1)]
        [InlineData(-5, 0, -5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            var calcTester = new Calculator();
            var actual = calcTester.Subtract(minuend, subtrhend);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(2, 3, 6)]
        [InlineData(-8, 3, -24)]
        [InlineData(2, 300, 600)]
        [InlineData(1, -1, -1)]
        [InlineData(-5, 1, -5)]
        [InlineData(-5, -1, 5)]
        [InlineData(0, -1, 0)]
        [InlineData(-5, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var MrHandyDandyCalculatorTester = new Calculator();
            var theActual = MrHandyDandyCalculatorTester.Multiply(num1, num2);
            Assert.Equal(expected, theActual);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(2, 3, 0)]
        [InlineData(-8, 3, -2)]
        [InlineData(2, 300, 0)]
        [InlineData(1, -1, -1)]
        [InlineData(-5, 1, -5)]
        [InlineData(0, 1, 0)]
        [InlineData(-5, 0, 0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            var milkBreadEggs = new Calculator();
            var yactual = milkBreadEggs.Divide(num1, num2);
            Assert.Equal(expected, yactual);
        }
    }
}
