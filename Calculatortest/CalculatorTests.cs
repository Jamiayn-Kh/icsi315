using Xunit;
using CalculatorLibrary;

namespace CalculatorTest
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(5, 3);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Subtract(10, 4);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Result_AfterAddOperation_ReturnsSameValue()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var addResult = calculator.Add(7, 3);

            // Assert
            Assert.Equal(addResult, calculator.Result);
        }

        [Fact]
        public void Result_AfterSubtractOperation_ReturnsSameValue()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var subtractResult = calculator.Subtract(15, 7);

            // Assert
            Assert.Equal(subtractResult, calculator.Result);
        }

        [Fact]
        public void StoreInMemory_StoresValue_CanBeRecalled()
        {
            // Arrange
            var calculator = new Calculator();
            double valueToStore = 42;

            // Act
            calculator.StoreInMemory(valueToStore);
            var recalledValue = calculator.RecallMemory();

            // Assert
            Assert.Equal(valueToStore, recalledValue);
        }

        [Fact]
        public void ClearMemory_SetsMemoryToZero()
        {
            // Arrange
            var calculator = new Calculator();
            calculator.StoreInMemory(100);

            // Act
            calculator.ClearMemory();

            // Assert
            Assert.Equal(0, calculator.RecallMemory());
        }

        [Fact]
        public void AddToMemory_AddsValueToExistingMemory()
        {
            // Arrange
            var calculator = new Calculator();
            calculator.StoreInMemory(50);

            // Act
            var result = calculator.AddToMemory(30);

            // Assert
            Assert.Equal(80, result);
            Assert.Equal(80, calculator.RecallMemory());
        }

        [Fact]
        public void SubtractFromMemory_SubtractsValueFromExistingMemory()
        {
            // Arrange
            var calculator = new Calculator();
            calculator.StoreInMemory(50);

            // Act
            var result = calculator.SubtractFromMemory(20);

            // Assert
            Assert.Equal(30, result);
            Assert.Equal(30, calculator.RecallMemory());
        }
    }
}