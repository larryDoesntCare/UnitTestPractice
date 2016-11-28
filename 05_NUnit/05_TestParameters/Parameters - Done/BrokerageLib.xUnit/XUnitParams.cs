using System;
using System.Collections.Generic;
using Xunit;

using SUT = BrokerageLib;

namespace BrokerageLib.xUnit {
	public class XUnitParams {

		[Fact]
		public void ReturnTrue_WhenThereIsAOne() {
			// arrange
			var analyzer = new SUT.NumberAnalyzer(2201);

			// act
			var result = analyzer.ContainsOddDigit();

			// assert
			Assert.True(result);
		}

		[Theory]
		[InlineData(2201)]
		[InlineData(603)]
		[InlineData(700)]
		public void ReturnTrue_WhenThereIsAOddDigit(int candidate) {
			// arrange
			var analyzer = new SUT.NumberAnalyzer(candidate);

			// act
			var result = analyzer.ContainsOddDigit();

			// assert
			Assert.True(result);

		}
		[Theory]
		[InlineData(101, 1, 2)]
		[InlineData(222345, 2, 3)]
		[InlineData(123, 4, 0)]
		public void ReturnsCount_Theory(int candidateNumber,
																		 int testDigit,
																		 int expectedCount) {
			// arrange

			var analyzer = new SUT.NumberAnalyzer(candidateNumber);

			// act

			var result = analyzer.GetTheCountOfThisDigit(testDigit);

			// assert

			Assert.Equal(expectedCount, result);

		}
	}
}
