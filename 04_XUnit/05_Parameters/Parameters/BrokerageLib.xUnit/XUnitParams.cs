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
		
		public void ReturnTrue_WhenThereIsAOddDigit() {
			// arrange
			var analyzer = new SUT.NumberAnalyzer(2201);

			// act
			var result = analyzer.ContainsOddDigit();

			// assert
			Assert.True(result);

		}
	}
}
