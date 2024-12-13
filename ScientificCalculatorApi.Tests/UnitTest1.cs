using Xunit;
using ScientificCalculatorApi.Services;
using System;

namespace ScientificCalculatorApi.Tests
{
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorServiceTests()
        {
            // Arrange: Initialize CalculatorService
            _calculatorService = new CalculatorService();
        }

        // Test for Add method
        [Fact]
        public void Add_ReturnsCorrectSum_WhenGivenTwoNumbers()
        {
            // Act
            var result = _calculatorService.Add(3.0, 2.0);

            // Assert
            Assert.Equal(5.0, result);
        }

        // Test for Subtract method
        [Fact]
        public void Subtract_ReturnsCorrectDifference_WhenGivenTwoNumbers()
        {
            var result = _calculatorService.Subtract(5.0, 3.0);
            Assert.Equal(2.0, result);
        }

        // Test for Multiply method
        [Fact]
        public void Multiply_ReturnsCorrectProduct_WhenGivenTwoNumbers()
        {
            var result = _calculatorService.Multiply(4.0, 2.0);
            Assert.Equal(8.0, result);
        }

        // Test for Divide method
        [Fact]
        public void Divide_ReturnsCorrectQuotient_WhenGivenTwoNumbers()
        {
            var result = _calculatorService.Divide(10.0, 2.0);
            Assert.Equal(5.0, result);
        }

        // Test for Divide method with zero denominator (Exception case)
        [Fact]
        public void Divide_ThrowsDivideByZeroException_WhenDividingByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculatorService.Divide(10.0, 0));
        }

        // Test for SquareRoot method
        [Fact]
        public void SquareRoot_ReturnsCorrectSquareRoot_WhenGivenANumber()
        {
            var result = _calculatorService.SquareRoot(16.0);
            Assert.Equal(4.0, result);
        }

        // Test for Exponent method
        [Fact]
        public void Exponent_ReturnsCorrectPower_WhenGivenBaseAndExponent()
        {
            var result = _calculatorService.Exponent(2.0, 3.0);
            Assert.Equal(8.0, result); // 2^3 = 8
        }

        // Test for Percentage method
        [Fact]
        public void Percentage_ReturnsCorrectPercentage_WhenGivenValueAndTotal()
        {
            var result = _calculatorService.Percentage(20.0, 200.0);
            Assert.Equal(10.0, result); // (20/200) * 100 = 10%
        }

       

    }
}