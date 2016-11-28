using System;
using System.Collections.Generic;
using Xunit;
using SUT = BrokerageLib;

namespace BrokerageLib.xUnit {
	public class XUnitParams {

		[Theory]
		[InlineData(201)]
		public void ReturnTrue_WhenThereIsAOddDigit(int candidate) {
			// arrange
			var analyzer = new SUT.NumberAnalyzer(candidate);

			// act
			var result = analyzer.ContainsOddDigit();

			// assert
			Assert.True(result);

		}
	
	
	}
}
