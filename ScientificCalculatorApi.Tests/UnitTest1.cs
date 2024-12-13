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

        
    }
}