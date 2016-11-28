using System;
using System.Collections.Generic;
using Xunit;

using SUT = BrokerageLib;

namespace BrokerageLib.xUnit {
	public class XUnitParams {

		[Fact]
		public void ReturnsCount_Fact() {
			// arrange

			var analyzer = new SUT.NumberAnalyzer(444567);

			// act

			var result = analyzer.GetTheCountOfThisDigit(4);

			// assert

			Assert.Equal(3, result);

		}

		[Theory]
		[InlineData(101,1,2)]
		[InlineData(222345, 2, 3)]
		[InlineData(123, 4, 0)]
		public void ReturnsCount_Theory( int candidateNumber,
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
