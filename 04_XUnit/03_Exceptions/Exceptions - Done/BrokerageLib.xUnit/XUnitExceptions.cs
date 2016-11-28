using System;
using Xunit;
using SUT = BrokerageLib;

namespace BrokerageLib.xUnit {
	public class XUnitExceptions {

		[Fact]
		public void ThrowArgumentOutOfRangeException_WhenNegativeUnitsSold() {
			// Arrange
			var unitsSold = -2;
			var unitPrice = 50.00M;

			var calculator = new SUT.CommissionCalculator();

			// Act and Assert

			var argException = Assert.Throws<ArgumentOutOfRangeException>(() => calculator.DetermineVariableRate(unitsSold, unitPrice));

		}

		[Fact]
		public void ThrowArgumentOutOfRangeException_WhenNegativePrice() {
			// Arrange
			var unitsSold = 2;
			var unitPrice = -50.00M;
			var calculator = new SUT.CommissionCalculator();

			// Act
			var argException = Record.Exception(() => calculator.DetermineVariableRate(unitsSold, unitPrice));

			// Assert
			Assert.NotNull(argException);
			Assert.IsType(typeof(ArgumentOutOfRangeException), argException);

		}
		[Fact]
		public void DemoOfCheckingExceptionProperties() {
			// arrange
			var calculator = new SUT.CommissionCalculator();
			// Act and Assert

			var nullRefException = Assert.Throws<ArgumentNullException>(() => calculator.ParseStrings(null, "Example"));

			Assert.Equal("firstArg", nullRefException.ParamName);
		}

	}
}
