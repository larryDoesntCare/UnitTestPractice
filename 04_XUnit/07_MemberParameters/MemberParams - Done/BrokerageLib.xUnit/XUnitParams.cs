using System;
using System.Collections.Generic;
using Xunit;
using SUT = BrokerageLib;

namespace BrokerageLib.xUnit {
	public class XUnitParams {

		[Theory]
		[MemberData("GetTestNumbers")]
		public void ReturnTrue_WhenThereIsAOddDigit(int candidate) {
			// arrange
			var analyzer = new SUT.NumberAnalyzer(candidate);

			// act
			var result = analyzer.ContainsOddDigit();

			// assert
			Assert.True(result);

		}

		public static IEnumerable<object> GetTestNumbers() {
			for (int i = 1; i < 6; i += 2)
			{
				yield return new object[] { i };
			}

		}
	
	}
}
