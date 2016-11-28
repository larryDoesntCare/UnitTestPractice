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
		public void ReturnsCount_Theory() {
			// arrange

			var analyzer = new SUT.NumberAnalyzer(444567);

			// act

			var result = analyzer.GetTheCountOfThisDigit(4);

			// assert

			Assert.Equal(3, result);

		}

	}
}
